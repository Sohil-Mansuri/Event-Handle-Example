using EventHandlerExample.Example1;

namespace EventHandlerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var mailService = new MailService();
            var messageService = new MessageService();

            var videoEncode = new VideoEncoder();
            videoEncode.VideoEncodeEventHandler += mailService.SendEmail;
            videoEncode.VideoEncodeEventHandler += messageService.SendMessage;

            videoEncode.Encode(new Video { Title = "Bahubali"});

            Console.ReadKey();
        }
    }
}
