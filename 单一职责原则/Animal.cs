using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    public class Animal : BaseAnimal
    {
        public Animal(string name)
            :base(name)
        {

        }

        public override void Breath()
        {
            Console.WriteLine("{0}在呼吸",this._Name);
        }
    }
}
