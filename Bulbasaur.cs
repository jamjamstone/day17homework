using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17homework
{
    class Bulbasaur : Monster
    {
        public Bulbasaur(string monsterName, int level) : base()
        {
            _monsterName = monsterName;
            _level = level;
            _monsterType = MobType.Grass;
        }

        public override void BaseAttack()
        {

            Console.WriteLine("덩굴채찍");
        }
    }
}
