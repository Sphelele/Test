using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Sports
    {

        public virtual String getName()
        {
            return "Generic Sports";
        }

        public virtual void getNumberOfTeamMembers()
        {
            Console.Write("Each team has n players in " + getName());
        }

    }
}
