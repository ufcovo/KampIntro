using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method Injection
        public void MakeApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            // Evaluate applicant information
            //
            creditManager.Calculate();
            loggerService.Log();
        }
        public void MakeLoanPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
