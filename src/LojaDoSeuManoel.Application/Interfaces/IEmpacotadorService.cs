using LojaDoSeuManoel.Application.DTOs.Request;
using LojaDoSeuManoel.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.Interfaces
{
    public interface IEmpacotadorService
    {
        Task<ResponseDto> ProcessarPedidosAsync(RequestOrderDto pedidos);
    }
}
