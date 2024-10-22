
namespace EventHandlerExample.Example1
{
    /// <summary>
    /// Subscriber
    /// </summary>
    internal class MailService
    {
        public void SendEmail(object source, Video video)
        {
            Console.WriteLine("Sent a mail {0}", video.Title);
        }
    }
}
