using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.里氏替换原则
{
    /*
     * 里氏替换原则讲的是如何更好的使用继承
     * 1. 子类继承父类时，拥有父类的一切属性和方法，如果子类不存在父类中的属性或者方法时，应该断掉继承
     * 2. 子类继承父类如果是为了减少代码的重写时，不要修改父类的内容
     */ 
    public class LSPDemo
    {
        public static void Show()
        {
            //new virtual abstract的测试
            Poly.Test();

            //里氏替换原则
            Chinese chinese = new Chinese()
            {
                Name = "chenia",
                Age = 25,
            };
            chinese.Speak();
            chinese.Sleep();

            Japnese japnese = new Japnese()
            {
                Name = "桥本环奈",
                Age = 20,
            };
            japnese.Speak();
            japnese.Sleep();

            //Cat不会说话，不能继承people类
            Cat cat = new Cat();

        }
    }
}
