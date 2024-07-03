namespace Labb11Ball
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public Location Location { get; set; }


        public override string ToString() => $"{Name},{Team}";

        public void Run(object o, BallLocationChangedEventArgs args)
        {
            Ball b = o as Ball;
            Location = args.NewLocation;
            Console.WriteLine($"{this} is Running towards {Location}");

        }
    }
}
