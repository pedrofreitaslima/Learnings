using System;
using System.Threading;

namespace EventsAndDelegatesDemo
{
    public class VideoEncoder
    {
        // 1 - Define a delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2 - Define an event based on that delegate
        public event VideoEncodedEventHandler? VideoEncoded;

        // Exists in .NET method that represents the strategy learned.
        // EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> EventVideoEncoded;
        // EventHandler
        public event EventHandler EventVideoEncoding;

        // 3 - Raise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null && video != null)
                VideoEncoded(this, new VideoEventArgs(video));
        }

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding video {video.Title} ...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);

            System.Console.WriteLine($"Video {video.Title} encoded and sended...");
        }
    }
}
