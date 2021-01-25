using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Services
{
    public interface IUserInfo
    {
        List<userInfo> Users { get; }
    }
}
