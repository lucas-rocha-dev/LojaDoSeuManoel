using LojaDoSeuManoel.Application.DTOs.Request;
using LojaDoSeuManoel.Application.Services;

namespace TestLojaDoSeuManoel;

[TestClass]
public class EmpacotadorServiceTests
{
    private EmpacotadorService _service;

    [TestInitialize]
    public void Setup()
    {
        _service = new EmpacotadorService();
    }

    [TestMethod]
    public async Task ProcessarPedidosAsync_DeveRetornarCaixaCorreta_ParaPedidoSimples()
    {
        // Arrange
        var pedido = new RequestOrderDto {
            Pedidos = new List<OrderRequestDto>
            {
                    new OrderRequestDto
                    {
                        Pedido_id = 1,
                        produtos = new List<ProductRequestDto>
                        {
                            new ProductRequestDto
                            {
                                Produto_id = "PS5",
                                Dimensoes = new DimensoesRequestDto { Altura = 40, Largura = 10, Comprimento = 25 }
                            },
                            new ProductRequestDto
                            {
                                Produto_id = "Volante",
                                Dimensoes = new DimensoesRequestDto { Altura = 40, Largura = 30, Comprimento = 30 }
                            }
                        }
                    }
                }
        };

        // Act
        var resultado = await _service.ProcessarPedidosAsync(pedido);

        // Assert
        Assert.IsNotNull(resultado);
        Assert.AreEqual(1, resultado.pedidos.Count);

        var caixas = resultado.pedidos[0].Caixas;
        Assert.AreEqual(1, caixas.Count);
        Assert.AreEqual("Caixa 2", caixas[0].Caixa_id);
        CollectionAssert.AreEquivalent(new List<string> { "PS5", "Volante" }, caixas[0].Produtos);
    }

    [TestMethod]
    public async Task ProcessarPedidosAsync_DeveRetornarObservacao_QuandoProdutoNaoCouber()
    {
        // Arrange
        var pedido = new RequestOrderDto {
            Pedidos = new List<OrderRequestDto>
            {
                    new OrderRequestDto
                    {
                        Pedido_id = 2,
                        produtos = new List<ProductRequestDto>
                        {
                            new ProductRequestDto
                            {
                                Produto_id = "Cadeira Gamer",
                                Dimensoes = new DimensoesRequestDto { Altura = 120, Largura = 60, Comprimento = 70 }
                            }
                        }
                    }
                }
        };

        // Act
        var resultado = await _service.ProcessarPedidosAsync(pedido);

        // Assert
        var caixas = resultado.pedidos[0].Caixas;
        Assert.AreEqual(1, caixas.Count);
        Assert.IsNull(caixas[0].Caixa_id);
        Assert.AreEqual("Produto não cabe em nenhuma caixa disponível.", caixas[0].Observacao);
        CollectionAssert.AreEqual(new List<string> { "Cadeira Gamer" }, caixas[0].Produtos);
    }
}

