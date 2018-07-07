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

    public class Code_6_7
    {
        public static void Main(string[] args)
        {
            ResultPublishEvent e = new ResultPublishEvent();

            //Handlers
            EmailEventHandler email = new EmailEventHandler();

            e.PublishResult += email.SendEmail;

            e.PublishResultNow();

            Console.ReadLine();
        }
    }
}