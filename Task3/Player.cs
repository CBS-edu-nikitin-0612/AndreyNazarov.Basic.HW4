using System;

namespace Task3
{
    internal class Player : IPlayable, IRecodable
    {
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause playing");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause recording");
        }

        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop playing");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop recording");
        }
    }
}
