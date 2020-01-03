using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.依赖倒置原则
{
    public abstract class AbstractPhone
    {
        public string Brand { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }

        public abstract void Call();


        public abstract void Text();
        
    }
}
