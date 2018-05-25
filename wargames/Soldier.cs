using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wargames
{
    class Soldier:Player 
    {
        private string _soldierRank;
        private string _weapon;
        private int _health;
        private int _soldierStamina;
        private int _attackDmg;
        

        public string SoldierRank
        {
            get { return _soldierRank; }
            set { _soldierRank = value; }
        }

        public string Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public int Health
        {
            get { return _health; }

            set
            {
                if (Health <= 0)
                {
                    _health = 0;
                    Console.WriteLine($"{_soldierRank} has died.");
                    NumberOfSoldiers = NumberOfSoldiers - 1;
                } else if (Health >= 100) {
                    _health = 100;
                }
            }
        }

        public int SoldierStamina
        {
            get { return _soldierStamina; }
            set
            {
                if (SoldierStamina <= 0 || SoldierStamina > 50)
                {
                    _soldierStamina = 0;
                    Console.WriteLine($"{_soldierRank} must rest before entering battle.");
                } else if (SoldierStamina > 49)
                {
                    
                }

            }
        }






    }
}
