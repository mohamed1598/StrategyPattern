using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck_Simulation.Duck_Types;
namespace Duck_Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
            model.performQuack();
            Console.WriteLine("for Mallard Duck");
            Duck mallardDuck = new MallardDuck();
            mallardDuck.performFly();
            mallardDuck.performQuack();
            Console.ReadKey();
        }
    }
}
