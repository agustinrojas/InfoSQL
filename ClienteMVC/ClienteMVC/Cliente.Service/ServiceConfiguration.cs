using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Configuration;

namespace Cliente.Service
{
    public static class ServiceConfiguration
    {
        public static HttpClient IniClient (HttpClient HttpClient)
        {
            client.BaseAdress = new Uri(ConfigurationManager.AppSettings["BaseApiUri"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityValue("alpication/jsonn"));
            return client;
        }
    }
}
