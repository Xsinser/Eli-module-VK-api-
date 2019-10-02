using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
namespace Eli_modul__VK_api_
{
    class SNmain
    {
        string login,  pass;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public void Informing(string countM,string typeSN)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            synthesizer.Volume = 100;
            synthesizer.Rate = 0;
            synthesizer.Speak($"У вас обнаружено {countM} не прочитанное сообщение в {typeSN}");
        }

    }
}
