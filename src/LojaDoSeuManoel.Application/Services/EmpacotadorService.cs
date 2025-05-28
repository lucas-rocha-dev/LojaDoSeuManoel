using LojaDoSeuManoel.Application.DTOs;
using LojaDoSeuManoel.Application.Interfaces;

namespace LojaDoSeuManoel.Application.Services
{
    public class EmpacotadorService : IEmpacotadorService
    {
        public Task<ResponseDto> ProcessarPedidosAsync(RequestOrderDto pedidos)
        {
            throw new NotImplementedException();
        }
    }
}
