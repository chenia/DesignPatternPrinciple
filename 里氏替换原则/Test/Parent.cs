using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.里氏替换原则
{
    public abstract class Parent
    {
        public void CommonMethod()
        {
            Console.WriteLine("Parent's CommonMethod");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Parent's  VirtualMethod");
        }

        public abstract void AbstractMethod();
    }
}
