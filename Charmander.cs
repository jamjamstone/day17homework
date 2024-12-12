using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17homework
{
    class Charmander:Monster
    {
        public Charmander(string monsterName, int level) : base()
        {
            _monsterName = monsterName;
            _level = level;
            _monsterType = MobType.Fire;
        }
        public override void BaseAttack()
        {

            Console.WriteLine("화염방사");
        }
    }
}
