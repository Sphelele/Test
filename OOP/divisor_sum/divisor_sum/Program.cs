using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisor_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalculator obj = new MyCalculator();
            Console.Write(obj.divisor_sum(50003000));
            System.Threading.Thread.Sleep(5000);
        }
    }
}
