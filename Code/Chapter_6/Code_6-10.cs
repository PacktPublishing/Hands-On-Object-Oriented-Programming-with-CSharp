using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    public delegate void GetResult();

    public class ResultPublishEvent
    {
        public event GetResult PublishResult;

        public void PublishResultNow()
        {
            if (PublishResult != null)
            {
                Console.WriteLine("");
                Console.WriteLine("We are publishing the results now!");
                Console.WriteLine("");
                PublishResult();
            }
        }
    }

    public class EmailEventHandler
    {
        public void SendEmail()
        {
            Console.WriteLine("Results have been emailed successfully!");
        }
    }

    public class SmsEventHandler
    {
        public void SmsSender()
        {
            Console.WriteLine("Results have been messaged successfully!");
        }
    }

    public class Code_6_8
    {
        public static void Main(string[] args)
        {
            ResultPublishEvent e = new ResultPublishEvent();

            //Handlers
            EmailEventHandler email = new EmailEventHandler();
            SmsEventHandler sms = new SmsEventHandler();

            e.PublishResult += email.SendEmail;
            e.PublishResult += sms.SmsSender;

            e.PublishResultNow();

            e.PublishResult -= sms.SmsSender;

            e.PublishResultNow();

            Console.ReadLine();
        }
    }
}