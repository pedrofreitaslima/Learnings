using System;
using System.Threading;

namespace EventsAndDelegatesDemo
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email... ");
            Thread.Sleep(2000);
        }
        
    }
}
