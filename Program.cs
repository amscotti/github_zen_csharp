using System;
using System.Net;
using System.IO;

namespace github_zen_csharp
{
    class Program
    {
        const string apiURL = "https://api.github.com/zen";
        const string userAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";
        public static void Main(string[] args)
        {
            WebClient client = new WebClient();


            client.Headers.Add("user-agent", userAgent);

            Stream data = client.OpenRead(apiURL);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            Console.WriteLine(s);
            data.Close();
            reader.Close();
        }
    }
}