﻿using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main()
        {
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder();      //Publisher
            var mailService = new MailService();        //Subscriber
            var messageService = new MessageService();  //Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
