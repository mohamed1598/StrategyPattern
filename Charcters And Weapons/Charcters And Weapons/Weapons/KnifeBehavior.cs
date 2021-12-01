using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charcters_And_Weapons.Weapons
{
    class KnifeBehavior : iWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Character Is Now Using Knife");
        }
    }
}
