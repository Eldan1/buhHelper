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
            //Console.WriteLine(\"введеный инн {0}\",inn,inn);
            Console.Write(inn);
            //var url = "https://focus-api.kontur.ru/api3/req?key=3208d29d15c507395db770d0e65f3711e40374df&inn=6663003127";

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
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);

            // Clean up the streams and the response.
            reader.Close();

            response.Close();

            Console.ReadKey();
        }
    }


}