using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17homework
{
    class Squirtle : Monster
    {
        public Squirtle(string monsterName, int level) : base()
        {
            _monsterName = monsterName;
            _level = level;
            _monsterType = MobType.Water;
        }   
        public override void BaseAttack()
        {

            Console.WriteLine("물총발사");
        }
    }
}
