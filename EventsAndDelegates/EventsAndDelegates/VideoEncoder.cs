using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        #region Notes On EventHandler Delegate
        /*
 * 1 - Define a Delegate (Agreement between publisher and subscriber)
 * 2 - Define an event based on that Delegate
 * 3 - Raise or publish the event
 */

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        /*
         * New Event Delegates in .NET 2.0
         * 'EventHandler'
         * 'EventHandler<TEventArgs>' its Generic form
         */
        #endregion

        public event EventHandler<VideoEventArgs> VideoEncoded;
        //public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() {Video = video});
        }
    }
}