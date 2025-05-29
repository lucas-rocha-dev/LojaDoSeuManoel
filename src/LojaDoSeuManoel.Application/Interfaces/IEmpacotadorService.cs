using LojaDoSeuManoel.Application.DTOs.Request;
using LojaDoSeuManoel.Application.DTOs.Response;

namespace LojaDoSeuManoel.Application.Interfaces
{
    public interface IEmpacotadorService
    {
        Task<ResponseDto> ProcessarPedidosAsync(RequestOrderDto pedidos);
    }
}
