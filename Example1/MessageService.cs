
namespace EventHandlerExample.Example1
{
    /// <summary>
    /// Subscriber
    /// </summary>
    internal class MessageService
    {
        public void SendMessage(object source, Video video)
        {
            Console.WriteLine("Sent a message {0}", video.Title);
        }
    }
}
