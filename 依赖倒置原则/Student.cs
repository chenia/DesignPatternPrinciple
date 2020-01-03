using DesignPatternPrinciple.依赖倒置原则.Telephone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.依赖倒置原则
{
    public class Student
    {
        public string Name { get; set; }

        //依赖细节（手机）
        public void PlayMI(MI mi)
        {
            Console.WriteLine($"{Name} is playing {mi.Brand}");
        }


        public void PlayHonor(Honor honor)
        {
            Console.WriteLine($"{Name} is playing {honor.Brand}");
        }


        public void PlayIphone(IPhone iphone)
        {
            Console.WriteLine($"{Name} is playing {iphone.Brand}");
        }

        //依赖细节
        public void Play(AbstractPhone abstractPhone)
        {
            Console.WriteLine($"{Name} is playing {abstractPhone.Brand}");
        }
    }
}
