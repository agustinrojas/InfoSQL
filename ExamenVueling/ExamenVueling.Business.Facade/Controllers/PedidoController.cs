using ExamenVueling.Business.Logic;
using ExamenVueling.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ExamenVueling.Business.Facade.Controllers
{
    public class PedidoController : ApiController
    {
        private readonly IPedidoBL _ipedidoBL = null;

        public PedidoController(IPedidoBL ipedidoBL)
        {
            _ipedidoBL = ipedidoBL;
        }

        /// <summary>
        /// Muestras un pedido con Get.
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public IHttpActionResult Get()
        {
            return Ok(_ipedidoBL.Get());
        }

        /// <summary>
        /// Introduces pedido y lo guardas en redis.
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        [HttpPost()]
        public IHttpActionResult Set(Pedido pedido)
        {

            return Ok(_ipedidoBL.Set(pedido));
        }
    }
}