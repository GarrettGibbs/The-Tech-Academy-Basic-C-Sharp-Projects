using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment34
{
    class Maths
    {
        public Maths(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
            Result = number1 + number2;
        }
        public Maths(int number1) : this(number1, 10) { }

        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }


    }
}
