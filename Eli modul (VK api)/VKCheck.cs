using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using VkNet;
using VkNet.Abstractions;
using VkNet.AudioBypassService.Extensions;
using VkNet.Model;


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
        VkApi AuthorizeInSN()
        {
            var services = new ServiceCollection();
            services.AddAudioBypass();
            var api = new VkApi(services);
            api.Authorize(new ApiAuthParams { Login = login, Password = password });
            return api;
        }

       public VKCheck()
        {
            VkApi api = AuthorizeInSN();
            //statusLabel.Content = api.Token.ToString();
            //var res = api.Groups.Get(new GroupsGetParams());
            //statusLabel.Content = res.TotalCount;
            var k = api.Messages.GetDialogs(new VkNet.Model.RequestParams.MessagesDialogsGetParams{Count = 200});
           // if(k.Unread!=null)

            ///uint z = k.Unread.Value;
        }
    
    
    }
}
