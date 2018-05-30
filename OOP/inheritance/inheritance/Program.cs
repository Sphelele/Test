using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Soccer obj = new Soccer();
            Sports obj1 = new Sports();

            obj1.getNumberOfTeamMembers();
            Console.Write("\n");
            obj.getNumberOfTeamMembers();
            System.Threading.Thread.Sleep(50000);

        }
    }
}
