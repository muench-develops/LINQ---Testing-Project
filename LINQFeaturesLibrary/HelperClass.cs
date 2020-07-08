using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;



namespace LINQFeaturesLibrary
{
    public class HelperClass
    {
        public static IEnumerable<Employee> InitializeDevelopers()
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee{ID=1, Name="Max"},
                new Employee{ID=2, Name="Steve"}
            };

            return developers;
        }

        //public static IEnumerable<Employee> InitializeSales()
        //{
        //    IEnumerable<Employee> sales = new List<Employee>() {
        //        new Employee{ID=3, Name="Steve"}
        //    };

        //    return sales;
        //}


        public static void WriteDevelopersToConsole(IEnumerable<Employee> developers)
        {
            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine($"{enumerator.Current.Name} - ID {enumerator.Current.ID}");
            //}          

            //foreach(var employee in developers.Where(NameStartsWithS))
            //{
            //    Console.WriteLine($"{employee.Name}");
            //}

            //foreach (Employee employee in developers.Where(delegate (Employee arg)
            //{
            //    return arg.Name.StartsWith("S");
            //}))
            //{
            //    Console.WriteLine($"{employee.Name}");
            //}

            //Linq Query
            foreach (Employee employee in developers.Where(e => e.Name.StartsWith("S")).OrderBy(e=>e.Name))
            {
                Console.WriteLine($"{employee.Name}");
            }

            Console.WriteLine($"Items in developers: {developers.Count()}");
        }

        private static bool NameStartsWithS(Employee arg) => arg.Name.StartsWith("S");

    }
}
