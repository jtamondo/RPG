using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_260FInal
{
    class Enemy : Character
    {
        public Enemy(int level, int EnemyNum)
        {
            switch (EnemyNum)
            {
                case 1:
                    this.name = "Drone";
                    this.hp = 5 * level;
                    this.spd = 1;
                    break;
                case 2:
                    this.name = "Tiger";
                    this.hp = 10 * level;
                    this.spd = 4;
                    break;
            }
        }
    }
}
