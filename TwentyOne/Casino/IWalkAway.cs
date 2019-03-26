using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    interface IWalkAway
    {
        //everything is public in an interface so you do not need to specify that
        void WalkAway(Player player);
    }
}
