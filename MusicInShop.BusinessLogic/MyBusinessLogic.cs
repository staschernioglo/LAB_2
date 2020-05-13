using MusicInShop.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicInShop.BusinessLogic
{
    public class MyBusinessLogic 
    { 
        public ISession GetSessionBL() 
        { 
            return new SessionBL();
        } 
    }
}
