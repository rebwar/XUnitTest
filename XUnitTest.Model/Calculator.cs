using System;

namespace XUnitTest.Model
{
    public class Calculator
    {
        public int Result { get; set; }
        public Calculator()
        {
            System.Threading.Thread.Sleep(3000);
        }
        public void Sum(int num1,int num2)
        {
            Result= num1 + num2;
        }
        public void Sub(int num1,int num2)
        {
            Result= num1 - num2;
        }
    }
}
