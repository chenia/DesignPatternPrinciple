using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    public class Fish:BaseAnimal
    {
        public Fish(string name)
            :base(name)
        {  }

        public override void Breath()
        {
            Console.WriteLine("{0}在水中生存",this._Name);
        }
    }
}
