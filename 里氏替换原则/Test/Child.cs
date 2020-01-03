using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.里氏替换原则
{
    public class Child : Parent
    {
        /// <summary>
        /// 子类隐藏父类的方法，使用关键字new
        /// </summary>
        public new void CommonMethod()
        {
            Console.WriteLine("Child's CommonMethod");
        }

        public override void VirtualMethod()
        {
            Console.WriteLine("Child's VirtualMethod");           
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Child's AbstractMethod");
        }
    }
}
