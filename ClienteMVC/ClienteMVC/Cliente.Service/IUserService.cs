using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Service
{
    public interface IUserService
    {
        UserServiceModel Get();
        UserServiceModel Set(UserServiceModel userServiceModel);
    }
}
