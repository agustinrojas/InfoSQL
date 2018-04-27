using ExamenVueling.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.DataAcces.Dao.Interfaces
{
    public interface ISet
    {
        Pedido Set(Pedido pedido);
    }
}
