using MusicInShop.BusinessLogic.Core;
using MusicInShop.BusinessLogic.Interfaces;
using MusicInShop.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicInShop.BusinessLogic
{
    public class SessionBL : UserApi, ISession 
        { 
            public ULoginResp UserLogin(ULoginData data)
              { 
                 return UserLoginAction(data);
              }
        }
}
