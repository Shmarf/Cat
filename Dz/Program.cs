using System;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace Dz
{
    class Program
    {
        static void Main(string[] args)
            
        {
            

            Cat cat1 = new Cat("Marisia", new DateTime(2000, 03, 08));
            Cat cat = new Cat("Marusia", new DateTime(2001, 03, 05));
            cat.Makenois();
            cat.HungryStatus = 150;
            CatSmartHouse catSmartH = new CatSmartHouse(900);
            catSmartH.AddCat(cat1);
            catSmartH.AddCat(cat);




            Console.WriteLine($"Кошке по имени{cat.Name} уже {cat.GatAge()} лет");

            Console.ReadLine();

        }
       
    }
}