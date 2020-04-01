using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting WFC server...");
            ServiceHost host = new ServiceHost(typeof(Service), new Uri("http://localhost:8000/PC"));
            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine(
                    $"A (address): {se.Address} \nB (binding): {se.Binding.Name} \nC (contract): {se.Contract.Name}\n"
                );

            host.Open();
            Console.WriteLine("Server started. Waiting for connections...");
            Console.WriteLine("Press Enter to close the server!");
            Console.ReadKey();
            host.Close();
        }
    }
}
