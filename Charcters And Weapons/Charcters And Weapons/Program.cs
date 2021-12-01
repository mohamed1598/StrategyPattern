using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Charcters_And_Weapons.Charcters;
using Charcters_And_Weapons.Weapons;
namespace Charcters_And_Weapons
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new King();
            character.fight();
            Console.ReadKey();
            character.setWeapon(new AxeBehavior());
            character.fight();
            Console.ReadKey();
            character.setWeapon(new BowAndArrowBehavior());
            character.fight();
            Console.ReadKey();
            character.setWeapon(new KnifeBehavior());
            character.fight();
            Console.ReadKey();
            character.setWeapon(new SwordBehavior());
            character.fight();
            Console.ReadKey();
        }
    }
}
