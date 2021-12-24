using System;
using System.Threading;

namespace EventsAndDelegatesDemo
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a message... ");
            Thread.Sleep(2000);
        }
    }
}
