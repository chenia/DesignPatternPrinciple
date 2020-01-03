using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    public class Chicken : BaseAnimal
    {
        public Chicken(string name)
            :base(name)  
        {
            //子类的构造函数默认调用父类的构造函数
            //当父类的无参数构造被替代后，子类在构造时调用有参数的构造，用base
        }

        public override void Breath()
        {
            Console.WriteLine("{0}在陆地生存",this._Name);
        }
    }
}
