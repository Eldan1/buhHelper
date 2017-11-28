using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Consol = System.Console;

namespace EveryDay.BuhHelper
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ИНН ");
            string inn = Console.ReadLine();
            Console.Write(inn);
            // инн вводим и выврдим на консоль, но так как другие ИНН выдают "запрет" - возвращаем действуюущий
            inn = "6663003127";
            Console.Write(" ");
            Console.Write("всё равно используем 6663003127 так как другие запрещены");
            var url = "https://focus-api.kontur.ru/api3/req?key=3208d29d15c507395db770d0e65f3711e40374df&inn=" + inn;
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create(url);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            //string responseFromServer = reader.ReadToEnd();
            string responseFromServer = reader.ReadLine();
            // Display the content.
            

            Console.Write("Руководитель: ");
            //выводим построку от heads до innfl, лишние вимволы обрезаем
            string s1 = responseFromServer.Substring(responseFromServer.IndexOf("heads")+15, responseFromServer.IndexOf("innfl") - responseFromServer.IndexOf("heads")-16);
            Console.WriteLine(s1);


            Console.Write("наименование: ");
            //выводим построку от full до date, лишние cимволы обрезаем
            s1 = responseFromServer.Substring(responseFromServer.IndexOf("full")+6, responseFromServer.IndexOf("date")- responseFromServer.IndexOf("full")-10);
            Console.WriteLine(s1);
            // Clean up the streams and the response.
            reader.Close();

            response.Close();

            Console.ReadKey();
        }
    }


}