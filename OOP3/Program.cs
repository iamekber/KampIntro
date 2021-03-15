using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager = new PersonalCreditManager();           
            ICreditManager transportCreditManager = new TransportCreditManager();           
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager tradesCreditManager = new TradesCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(), new DatabaseLoggerService() };   

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(personalCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {personalCreditManager, transportCreditManager };
            
            //applicationManager.Creditİnformation(credits);
        }
    }
}
