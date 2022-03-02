using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyscig_tuptusia
{
    public class bet
    {
        public int amount;
        public int Dog;
        public guy bettor;

        public int PayOut(int Winner)
        {
            return (bettor.myBet.Dog == Winner) ? amount : -amount;
            
        }

    }
}
