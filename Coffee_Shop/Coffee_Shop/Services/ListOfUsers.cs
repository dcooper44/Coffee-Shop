using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Services
{
    public class ListOfUsers : IUserInfo
    {
        public List<userInfo> Users { get; } = new List<userInfo>();
    }
}
