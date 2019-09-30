using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eli_modul__VK_api_
{
    class SNchecker
    {
        Dictionary<string, SNmain> snTypes = new Dictionary<string, SNmain>(1);
       
        ISNchecker nchecker;
        public SNchecker(string login,string pass,string snType)
        {
            snTypes.Add("VK", new VKCheck());
          
            var bufObj = snTypes[snType];
            if(bufObj is VKCheck)
            {
                nchecker = (VKCheck)bufObj;
            }
        }
    }
}
