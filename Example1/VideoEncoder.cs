
namespace EventHandlerExample.Example1
{
    /// <summary>
    /// Publisher
    /// </summary>
    internal class VideoEncoder
    {
        public EventHandler<Video> VideoEncodeEventHandler;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding a video");
            Thread.Sleep(4000);
            Console.WriteLine("Encoding is done");

            OnEncoded(video);
        }

        protected void OnEncoded(Video video)
        {
            VideoEncodeEventHandler?.Invoke(this, video);
        }
    }
}
