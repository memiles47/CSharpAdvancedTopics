using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object sourse, VideoEventArgs e)
        {
            Console.WriteLine($"MessgeService: Sending a Text Message... {e.Video.Title}");
            Thread.Sleep(5000);
        }
    }
}