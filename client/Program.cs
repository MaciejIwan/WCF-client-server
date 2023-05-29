using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using client.ServiceBookReference;
namespace client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Click <ENTER> to start");
            Console.ReadLine();
            Console.WriteLine("App started");
            ServiceBookClient client = new ServiceBookClient();
            
            Console.WriteLine(client.HelloWorld());
            Console.WriteLine(client.Hi("Maciej Iwan"));
            Console.WriteLine(client.sum(2, 3));

            Console.WriteLine("Click <ENTER> to exit");
            Console.ReadLine();
        }
    }
}
