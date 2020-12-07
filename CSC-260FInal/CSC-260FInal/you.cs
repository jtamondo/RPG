using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_260FInal
{
    class You : Character
    {
        public int xp;
        public You(string val)
        {
            this.name = val;
            this.level = 1;
            this.hp = 40 * level;
            this.xp = 0;
            this.spd = 5;
        }

        public int get_xp()
        {
            return this.xp;
        }


    }
}
