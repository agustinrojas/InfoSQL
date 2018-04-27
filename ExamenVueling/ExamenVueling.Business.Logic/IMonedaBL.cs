using ExamenVueling.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Business.Logic
{
    public interface IMonedaBL
    {
        Moneda Set(Moneda moneda);
        Moneda Get();
    }
}
