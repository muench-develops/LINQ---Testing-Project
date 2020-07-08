using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;



namespace LINQFeaturesLibrary
{
    public class LINQHelperClass
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
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"{enumerator.Current.Name} - ID {enumerator.Current.ID}");
            }          

            Console.WriteLine($"Items in developers: {developers.Count()}");
        }
    }
}
