using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charcters_And_Weapons.Charcters
{
    public class King : Character
    {
        public override void fight()
        {
            weaponBehavior.useWeapon();
        }
    }
}
