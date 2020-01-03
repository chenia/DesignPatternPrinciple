using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.里氏替换原则
{
    /*
     * 1. 普通方法在调用的时候以左边类型为主，编译时决定的
     * 2. virtual方法和abstract方法在调用的时候以右边类型为主，运行时决定的
     * 3. 反射调用时，不一样，因为反射也是在运行时决定的
     */
    public class Poly
    {
        public static void Test()
        {
            Parent instance = new Child();
            instance.CommonMethod();   //调用的是父类的方法
            instance.VirtualMethod();  //调用的是子类的方法
            instance.AbstractMethod();  //调用的是子类的方法

        }
    }
}
