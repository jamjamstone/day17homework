using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17homework
{
    class Pikachu : Monster
    {
        public Pikachu(string monsterName, int level) : base()
        {
            _monsterName = monsterName;
            _level = level;
            _monsterType=MobType.Normal;
        }

        public override void BaseAttack()
        {
            
            Console.WriteLine("전광석화");
        }
    }
}
