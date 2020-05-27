using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Lesson7;

namespace Lesson6
{
    class PassportChecker
    {
        public int CheckPassportNumber(string passportNumber)
        {
            var count = 0;
            foreach (var letter in passportNumber)
            {
                if (letter.Equals("1"))
                {
                    count++;
                }
            }

            return count;
        }
        public void CheckPassport()
        {
            Console.WriteLine("hello");
        }
    }
}
