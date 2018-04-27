using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Service
{
    class UserService : IUserService
    {
        private readonly HttpClient _cliente;

        public UserService(HttpClient cliente)
        {
            this._cliente = cliente;
        }

        public async Task<UserServiceModel> GetAsync()
        {
            var message = await _cliente.GetAsync("");      
        }

        public UserServiceModel Set(UserServiceModel userServiceModel)
        {
            throw new NotImplementedException();
        }
    }
}
