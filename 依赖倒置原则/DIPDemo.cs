using DesignPatternPrinciple.依赖倒置原则.Telephone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.依赖倒置原则
{
    /*
     * 上层模块不应该直接依赖下层模块，二者可通过抽象依赖
     * 下层：具体细节的东西
     * 抽象：抽象类/接口
     */
    public class DIPDemo
    {
        public static void Show()
        {
            Student student = new Student() {Name = "chenia",};

            //直接依赖  学生上层使用下层时，必须将下层new出来，上层再调用对应的下层
            //若增加下层，则需要在上层处增加对应的方法
            MI mi = new MI();
            student.PlayMI(mi);

            Honor honor = new Honor();
            student.PlayHonor(honor);


            //使用抽象后，不用修改
            AbstractPhone abstractPhone = new MI();
            student.Play(abstractPhone);


            //ApplyPay只有IPhone中有,此时只能实例化细节
            IPhone iPhone = new IPhone();
            iPhone.ApplyPay();
        

                 
        }


    }
}
