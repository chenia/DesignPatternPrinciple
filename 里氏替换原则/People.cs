using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.里氏替换原则
{
    public class People
    {
        public string Name { get; set; }

        public int Age{ get; set; }


        public void Speak()
        {
            Console.WriteLine($"{Name} can speak");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} need sleep");
        }


    }
}
