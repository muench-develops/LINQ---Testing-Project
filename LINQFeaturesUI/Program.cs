using System;
using LINQFeaturesLibrary;

namespace LINQFeaturesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQHelperClass.WriteDevelopersToConsole(LINQHelperClass.InitializeDevelopers());
            Console.ReadLine();
        }
    }
}
