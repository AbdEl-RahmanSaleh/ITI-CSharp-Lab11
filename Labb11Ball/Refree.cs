namespace Labb11Ball
{
    public class Refree
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        public override string ToString() => $"{Name}";



        public void Look(object o,BallLocationChangedEventArgs args)
        {
            Ball b = o as Ball;
            Location = args.NewLocation;
            Console.WriteLine($"{this} is Looking at {Location}");

        } 


    }
}
