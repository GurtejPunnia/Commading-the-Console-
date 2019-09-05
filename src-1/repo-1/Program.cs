using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; 
using static System.Console;


namespace repo_1
{
   
    class Program
    {
        const string API_BASE = "https://www.gitignore.io/api/";
        const string API_LIST_LINES = API_BASE + "list? format=lines";
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var response = client.GetAsync
                (API_LIST_LINES).GetAwaiter().GetResult();
            if(response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync
                    ().GetAwaiter().GetResult();
                WriteLine(content);
                

            }


           
        }
    }
}
