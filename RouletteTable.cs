using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWPF
{
    class RouletteTable
    {
        public int CurrentBet { get; set; }



        public void betLess(int currentBank)
        {
            if (currentBank >= 5)
            {
                this.CurrentBet -= 5;
            }
            // else- you aint go no money fool. quit frontin-- no need to notify, they know.
        }

       


    }

    

}
