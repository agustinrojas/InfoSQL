using ExamenVueling.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Business.Logic
{
    public interface IPedidoBL
    {
        Pedido Set(Pedido pedido);
        Pedido Get();
    }
}
