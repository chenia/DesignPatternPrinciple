using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    public class SRPDemo
    {
        public static void Show()
        {
            BaseAnimal chicken = new Chicken("chicken");
            chicken.Breath();


            BaseAnimal fish = new Fish("fish");
            fish.Breath();

        }
    }
}
