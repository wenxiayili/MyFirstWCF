using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWCF
{
    class Program
    {
        //服务启动
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HomeService)))
            {
                try
                {
                    host.Open();
                    Console.WriteLine("服务开启");
                    Console.Read();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
