using ExamenVueling.Common.Logic;
using ExamenVueling.DataAcces.Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Business.Logic
{
    public class PedidoBL : IPedidoBL
    {
        private readonly IDao _idao = null;

        public PedidoBL(IDao idao)
        {
            this._idao = idao;
        }

        public Pedido Get()
        {
            return this._idao.Get();
        }

        public Pedido Set(Pedido pedido)
        {
            return this._idao.Set(pedido);
        }
    }
}
