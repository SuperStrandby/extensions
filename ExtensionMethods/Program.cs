using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new[] { 4, 6, 4, 99, 2, 2 };
            String str = list.Concat(", ");
            Console.WriteLine(str);

            IList<int> list2 = new[] { 4, 6, 4, 99, 2, 2 };
            String str2 = String.Join(", ", list2);
            Console.WriteLine(str2);

            IList<int> list3 = new[] { 4, 6, 4, 99, 2, 2 };
            list3.Concat(", ").Print();

           
        }
    }
}
