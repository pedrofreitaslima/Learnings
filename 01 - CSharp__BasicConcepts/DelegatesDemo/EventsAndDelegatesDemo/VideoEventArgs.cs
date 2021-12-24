namespace EventsAndDelegatesDemo
{
    public class VideoEventArgs
    {
        public Video Video { get; set; }
        public VideoEventArgs(Video video) => this.Video = video;
    }
}
