namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.Play();
            ((IPlayable)player).Stop();
            ((IPlayable)player).Pause();

            player.Record();
            ((IRecodable)player).Stop();
            ((IRecodable)player).Pause();
        }
    }
}
