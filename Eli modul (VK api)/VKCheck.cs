using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eli_modul__VK_api_
{
    class VKCheck:SNmain,ISNchecker
    {
        string login, password;
        string token;
       public void Check(string login,string pass){
            Login = login;
            Pass = pass;     
       }
       public VKCheck()
        {

        }
    
    
    }
}
