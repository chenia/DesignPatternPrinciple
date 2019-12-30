using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    public abstract class BaseAnimal
    {
        protected string _Name = null;
        public BaseAnimal(string name)
        {

            this._Name = name;
        }
        public abstract void Breath();
    }
}
