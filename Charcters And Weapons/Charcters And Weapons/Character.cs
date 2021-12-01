using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Charcters_And_Weapons.Weapons;
namespace Charcters_And_Weapons
{
    public abstract class Character
    {
        public Character()
        {
            weaponBehavior = new WithoutWeaponBehavior();
        }
        public iWeaponBehavior weaponBehavior;
        public abstract void fight();
        public void setWeapon(iWeaponBehavior weaponBehavior)
        {
            this.weaponBehavior = weaponBehavior;
        }
    }
}
