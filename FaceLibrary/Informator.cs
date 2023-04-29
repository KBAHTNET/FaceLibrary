using System.Media;
using System.Diagnostics;
using System.Timers;
using System.Net.Http;
using System.Collections.Generic;

namespace FaceLibrary
{
    public static class Informator
    {
        public static SoundPlayer player = new SoundPlayer("1.wav");

        private static int wavLengthSeconds = 8;
        private static System.Timers.Timer timer;

        public static List<Face> DetectedFaces = new List<Face>();


        #region сервис smsc

        private static string Url = "http://smsc.ru/sys/send.php";
        private static  string Login="ilya_r";
        private static string Password = "22062000";

        private static string SenderName = "CopIB";

        public static void SendMsg(string msg, params string[] phoneNumbers)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("login", Login);
            parameters.Add("psw", Password);
            parameters.Add("phones", "");
            parameters.Add("mes", msg);
            parameters.Add("cost", "0");
            parameters.Add("sender", SenderName);
            parameters.Add("fmt", "3");

            foreach(var phoneNumber in phoneNumbers)
            {
                parameters["phones"] = phoneNumber;

                string url_params = "";
                foreach(var param in parameters)
                {
                    url_params += param.Key + "=" + param.Value + "&";
                }

                int index = url_params.LastIndexOf('&');
                string temp = "";
                for(int i = 0; i < url_params.Length; i++)
                {
                    if(i!=index)
                        temp += url_params[i];
                }
                url_params = temp;
                temp = null;

                string allUrl = Url + "?" + url_params;

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, allUrl);
                HttpClient client = new HttpClient();
                client.SendAsync(request);
            }
        }

        #endregion


        public static void PlaySignal()
        {
            if (!Configs.IsSignalPlay)
            {
                timer = new System.Timers.Timer(wavLengthSeconds * 1000);
                timer.Elapsed += Timer_Elapsed;

                player.Play();

                timer.Start();

                Configs.IsSignalPlay = true;
            }
        }

        public static void Reaction(Face face)
        {
            DetectedFaces.Add(face);
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Configs.IsSignalPlay = false;
        }
    }
}
