﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.依赖倒置原则.Telephone
{
    public class IPhone:AbstractPhone
    {
        //public string Brand { get; set; }
        //public double Price { get; set; }
        //public string Color { get; set; }

        public override void Call()
        {
            Console.WriteLine($"The phone type is {Brand}");
        }

        public override void Text()
        {
            Console.WriteLine($"The phone type is {Brand}");
        }


        public void ApplyPay()
        {
            Console.WriteLine($"{Brand} can Pay Money");
        }
    }
}
