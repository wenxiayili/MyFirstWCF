using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeServiceReference.HomeServiceClient client = new HomeServiceReference.HomeServiceClient();

            var s = client.GetLength("1234");

            Console.WriteLine("长度为:{0}", s);

            Console.Read();
            
        }
    }
}
