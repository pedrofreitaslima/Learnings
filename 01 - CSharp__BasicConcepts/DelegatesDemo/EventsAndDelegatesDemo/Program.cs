namespace EventsAndDelegatesDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video("C# Events and Delegates Made Simple | Mosh ");
            var encoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;
            encoder.Encode(video);
        }
    }
}
