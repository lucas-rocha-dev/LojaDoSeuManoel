using LojaDoSeuManoel.Application.DTOs.Request;
using LojaDoSeuManoel.Application.DTOs.Response;
using LojaDoSeuManoel.Application.Interfaces;
using LojaDoSeuManoel.Domain.Entities;

namespace LojaDoSeuManoel.Application.Services
{
    public class EmpacotadorService : IEmpacotadorService
    {

        private readonly List<Box> _caixasDisponiveis = new()
        {
            new Box("Caixa 1", 30, 40, 80),
            new Box("Caixa 2", 80, 50, 40),
            new Box("Caixa 3", 50, 80, 60)
        };

        public async Task<ResponseDto> ProcessarPedidosAsync(RequestOrderDto pedidos)
        {
            var resposta = new ResponseDto();


            foreach (var pedido in pedidos.Pedidos) {
                var caixasUsadas = new List<BoxResponseDto>();
                var produtosNaoAlocados = new List<ProductRequestDto>(pedido.produtos);

                produtosNaoAlocados = produtosNaoAlocados
                    .OrderByDescending(p => CalcVolume(p.Dimensoes.Largura, p.Dimensoes.Altura, p.Dimensoes.Comprimento))
                    .ToList();

                foreach (var produto in produtosNaoAlocados) {
                    bool alocado = false;
                    foreach (var caixa in caixasUsadas) {
                        var caixaInfo = _caixasDisponiveis.First(c => c.Id.ToString() == caixa.Caixa_id);
                        if (ProdutoCabe(produto.Dimensoes, caixaInfo)) {
                            caixa.Produtos.Add(produto.Produto_id);
                            alocado = true;
                            break;
                        }
                    }
                    if (!alocado) {
                        foreach (var caixaTipo in _caixasDisponiveis) {
                            if (ProdutoCabe(produto.Dimensoes, caixaTipo)) {
                                caixasUsadas.Add(new BoxResponseDto {
                                    Caixa_id = caixaTipo.Id.ToString(),
                                    Produtos = new List<string> { produto.Produto_id }
                                });
                                alocado = true;
                                break;
                            }
                        }
                    }

                    if (!alocado) {
                        caixasUsadas.Add(new BoxResponseDto {
                            Caixa_id = null,
                            Produtos = new List<string> { produto.Produto_id },
                            Observacao = "Produto não cabe em nenhuma caixa disponível."
                        });
                    }
                }

                resposta.pedidos.Add(new OrderResponseDto {
                    Pedido_id = pedido.Pedido_id,
                    Caixas = caixasUsadas
                });
            }



            return await Task.FromResult(resposta);
        }



        public int CalcVolume(int largura, int altura, int profundidade)
        {
            return largura * altura * profundidade;
        }

        private bool ProdutoCabe(DimensoesRequestDto produto, Box caixa)
        {
            var p = new[] { produto.Altura, produto.Largura, produto.Comprimento }.OrderBy(x => x).ToArray();
            var c = new[] { caixa.Altura, caixa.Largura, caixa.Comprimento }.OrderBy(x => x).ToArray();

            return p[0] <= c[0] && p[1] <= c[1] && p[2] <= c[2];
        }
    }
}
