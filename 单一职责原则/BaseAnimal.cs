using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{  
    /*
     * 抽象类是将子类共同的内容抽取出来，不同的内容写成抽象，由不同的子类重写自己的内容
     */
    public abstract class BaseAnimal
    {
        protected string _Name = null;

        public BaseAnimal(string name)
        {
            this._Name = name;
        }

        //将不同的方法写在不同的类中
        public abstract void Breath();

        #region 逻辑判断和业务处理都写在一起了
        //public void Breath()
        //{
        //    if (this._Name == "chicken")
        //    {
        //        Console.WriteLine("{0}在陆地生存", this._Name);
        //    }
        //    else if (this._Name == "chicken")
        //    {
        //        Console.WriteLine("{0}在水中生存", this._Name);
        //    }
        //}
        #endregion
    }
}
