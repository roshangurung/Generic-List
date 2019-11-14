using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.Add(1);

            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
/////Output:{1,2,3,4,5,1}/////
