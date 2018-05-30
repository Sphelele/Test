using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisor_sum
{
    class MyCalculator : AdvancedArithmetic
    {
        public int divisor_sum(int n)
        {
            int sum = 0;
            int index = 1;
            while (n >= index)
            {
                if (n % index == 0)
                    sum += index;
                index++;
            }
            return (sum);
        }
    }
}
