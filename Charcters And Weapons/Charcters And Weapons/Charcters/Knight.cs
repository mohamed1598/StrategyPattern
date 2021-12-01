using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charcters_And_Weapons.Charcters
{
    class Knight : Character
    {
        public override void fight()
        {
            weaponBehavior.useWeapon();
        }
    }
}
