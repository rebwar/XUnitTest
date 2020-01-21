using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest.Model
{
   public class OddEven
    {
        public bool IsOdd { get; set; }
        public bool IsEven { get; set; }
        public void EvenCheck(int number)
        {
            if (number % 2 == 0)
            {
                IsEven = true;
            }
        }
        public void OddCheck(int number)
        {
            if (number % 2 != 0)
            {
                IsOdd = true;
            }
        }

    }
}
