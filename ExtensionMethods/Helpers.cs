using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Helpers
    {
        public static String Concat<T>(this IEnumerable<T> elements, String separator)
        {

            return string.Join(separator, elements);
        }

        public static void Print(this Object obj)
        {
            Console.WriteLine(obj);
        }

        public static void Act(this Object obj, Action<Object> action)
        {
            
            

           
        }
    }
}
