using LojaDoSeuManoel.Application.DTOs;
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
