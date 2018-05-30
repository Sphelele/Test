using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Soccer : Sports
    {
        public override String getName()
        {
            return "Soccer Class";
        }

        public override void getNumberOfTeamMembers()
        {
            Console.Write("Each team has 11 players in " + getName());
        }
    }
}
