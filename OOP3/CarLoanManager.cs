using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CarLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("The vehicle loan payment schedule has been calculated. ");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
