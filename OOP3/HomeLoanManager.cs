using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HomeLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("The housing loan payment plan has been calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
