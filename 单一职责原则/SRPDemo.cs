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
            Animal chicken = new Animal("chicken");
            chicken.Breath();

            BaseAnimal fish = new AnimalForWater("fish");
            fish.Breath();

            AnimalForWater shake = new AnimalForWater("shake");
            shake.Breath();


        }
    }
}
