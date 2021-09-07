using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    class Program
    {
        static void Main(string[] args)

        {
            var mytuple = Tuple.Create(2, "somnath", 9404300800, true, 0.23, 123, false, "veer");
            Console.WriteLine(mytuple.Item1);
            Console.WriteLine(mytuple.Item2);
            Console.WriteLine(mytuple.Item3);
            Console.WriteLine(mytuple.Item4);

            Console.WriteLine(mytuple.Item5);
            Console.WriteLine(mytuple.Item6);
            Console.WriteLine(mytuple.Item7);
            Console.WriteLine(mytuple.Rest);
            Console.ReadLine();

            '       }
                
    }
}
