using ExamenVueling.Common.Logic;
using ExamenVueling.DataAcces.Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Business.Logic
{
    public class MonedaBL : IMonedaBL
    {
        private readonly IDao _idao = null;

        public MonedaBL(IDao idao)
        {
            this._idao = idao;
        }

        public MonedaBL Get()
        {
            return this._idao.Get();
        }

        public MonedaBL Set(MonedaBL moneda)
        {
            return this._idao.Set(moneda);
        }
    }
}
