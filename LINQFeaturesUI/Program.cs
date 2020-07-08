using System;
using System.Security.Cryptography.X509Certificates;
using LINQFeaturesLibrary;

namespace LINQFeaturesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelperClass.WriteDevelopersToConsole(HelperClass.InitializeDevelopers());
            //Console.ReadLine();

            //Delegate
            Func<int, int> square = x => x * x;

            Console.WriteLine(square(2));
            Func<int, int, int> add = (x, y) => x + y;

            //No Return value
            Action<int> write = x => Console.WriteLine(x);

            write(add(5,10));

            Console.ReadLine();
            
        }
    }
}
