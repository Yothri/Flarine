using System;

namespace SampleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ether.Network Server";

            using (var server = new SampleServer())
                server.Start();
        }
    }
}