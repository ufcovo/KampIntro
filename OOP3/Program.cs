using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerLoanManager = new ConsumerLoanManager();
            ICreditManager carLoanManager = new CarLoanManager();
            ICreditManager homeLoanManager = new HomeLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(homeLoanManager, fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {consumerLoanManager, carLoanManager };
           // applicationManager.MakeLoanPreInformation(credits);

        }
    }
}
