﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment28
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("The employee's name is:");
            base.SayName();
        }
    }
}
