using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17homework
{
    abstract class Monster
    {
        protected int _level;
        protected MobType _monsterType;
        protected string _monsterName;
        public Monster()
        {
            _monsterType = MobType.Normal;
            _monsterName = "";
            _level = 1;
        }
        public Monster(MobType mobType, int level, string monsterName)
        {
            _monsterType= mobType;
            _monsterName = monsterName; 
            _level= level;
        }
        public MobType monsterType
        {
            get { return _monsterType; }
            set { _monsterType = value; }
        }
        public int level
        {
            get { return _level; }
            set { _level = value; }
        }
        public string monsterName
        {
            get { return _monsterName; }
            set { _monsterName = value; }
        }
        public virtual void BaseAttack()
        {

        }





    }//monster 끝


}
