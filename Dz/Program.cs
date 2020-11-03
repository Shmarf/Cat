using System;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.IO;

namespace Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Marusia", new DateTime(2001, 03, 05));
            cat.Makenois();
            
            Console.WriteLine($"Кошке по имени{cat.Name} уже {cat.GatAge()} лет");

            

        }
    }
}
}
