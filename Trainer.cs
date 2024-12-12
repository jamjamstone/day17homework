using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace day17homework
{
    enum MobType
    {
        Normal,Fire,Water,Grass
    }


    internal class Trainer
    {
        int _collectedSign;
        string _trainerName;
        string _startingMonster;
        Monster[] _monsters;
        static int _monsterNumber = 0;

        public Trainer()
        {
            _monsters=new Monster[6];
            _monsters[0] = new Pikachu("Pickachu",1);

            
        }
        public Trainer(string trainerName, string startingMonster)
        {
            _trainerName = trainerName;
            _startingMonster = startingMonster; 
            _monsters = new Monster[6];
            /*
            for (int i = 0; i < 6; i++)
            {
                _monsters[i] = new Monster();

            }*/
        }
        /*
        public Trainer(string trainerName, string startingMonster,MobType mobType, int level, string monsterName)
        {
            _trainerName = trainerName;
            _startingMonster = startingMonster;
            _monsters = new Monster[6];
            for(int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    _monsters[i] = new Monster(mobType,level,monsterName);
                }
                else
                {
                    _monsters[i] = new Monster();
                }
            }
            

        }*/
        public void ChangeStartMonster(string changeMonster)
        {
            _startingMonster=changeMonster;
        }
        public void ShowFirstMob()
        {
            Console.WriteLine(_monsters[0].level);
            Console.WriteLine(_monsters[0].monsterName);
            Console.WriteLine(_monsters[0].monsterType);
        }
        public void AddMonster(Monster monster)
        {
            if (_monsterNumber >= 6) 
            {
                Console.WriteLine("이미 6마리를 추가했습니다.");
                return;
            }
            _monsters[_monsterNumber] = monster; 
            _monsterNumber++;

        }
        public void AllAttack()
        {
            for (int i = 0; i < 6; i++) 
            {
                _monsters[i]?.BaseAttack();
            }
        }
    }
}
