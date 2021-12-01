using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charcters_And_Weapons.Weapons
{
    class BowAndArrowBehavior : iWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Character Is Know Using Bow And Arrow");
        }
    }
}
