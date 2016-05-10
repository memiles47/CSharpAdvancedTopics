using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object sourse, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending Email... {e.Video.Title}");
            Thread.Sleep(5000);
        }
    }
}