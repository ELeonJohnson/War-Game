using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wargames
{
    class Player
    {
        private int _armyPoints;
        private int _numberOfArmyBases;
        private int _numberOfSoldiers;


        public int ArmyPoints
        {
            get { return _armyPoints; }

            set { _armyPoints = value; }
        }

        public int NumberOfArmyBases
        {
            get { return _numberOfArmyBases; }
            set { _numberOfArmyBases = value; }
        }

        public int NumberOfSoldiers
        {
            get { return _numberOfSoldiers; }
            set { _numberOfSoldiers = value; }
        }
    }
}
