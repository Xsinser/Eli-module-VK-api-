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
using System.Data.SQLite;

namespace Eli_modul__VK_api_
{
    class VKCheck:SNmain,ISNchecker
    {
        string login, password;
         
        SQLiteConnection con = new SQLiteConnection("Data Source=usersBD.db; Password=Eli;");

        public string GetData(string nameRow)
        {
            con.Open();
            var com = new SQLiteCommand($"Select {nameRow} from Data where typeCode='VK'", con);
            var bufString = com.ExecuteScalar();
            
            con.Close();
            if (bufString != null)
                return (string)bufString;
            else
            return "error";
        }






        public void Check(string login,string pass){
            Login = login;
            Pass = pass;
            VkApi api = AuthorizeInSN();

            var bufferMessages = api.Messages.GetDialogs(new VkNet.Model.RequestParams.MessagesDialogsGetParams { Count = 200 });
            if (bufferMessages.Unread != null)
                Informing(bufferMessages.Unread.ToString(), "ВКонтакте");
        }


        VkApi AuthorizeInSN()
        {
            var services = new ServiceCollection();
            services.AddAudioBypass();
            var api = new VkApi(services);
            api.Authorize(new ApiAuthParams { Login = Login, Password = Pass });
            return api;
        }

       public VKCheck()
        {

        }

        public bool AuthorizeCheck(string login, string pass)
        {
            Login = login;
            Pass = pass;
            VkApi api = AuthorizeInSN();
            try
            {
                
            }
            catch
            {
                return false;
            }
            return true;
        }
    
    
    }
}
