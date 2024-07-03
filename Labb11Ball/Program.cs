namespace Labb11Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball b1 = new Ball();
            Player p1 = new Player() { Name = "Messi" , Team = "Barcelona"};
            Player p2 = new Player() { Name = "Suarez" , Team = "Barcelona"};
            Player p3 = new Player() { Name = "Neymar" , Team = "Barcelona"};
            Player p4 = new Player() { Name = "Xavi" , Team = "Barcelona"};

            Player p5 = new Player() { Name = "Ronaldo" , Team = "Real Madrid"};
            Player p6 = new Player() { Name = "Bale" , Team = "Real Madrid"};
            Player p7 = new Player() { Name = "Benzema" , Team = "Real Madrid"};
            Player p8 = new Player() { Name = "Isco" , Team = "Real Madrid"};

            Refree ref1 = new Refree() { Name="Michael Oliver"};


            

            Console.WriteLine("=============== After Subscribe ===============");
            b1.OnLocationChanged += p1.Run;
            b1.OnLocationChanged += p2.Run;
            b1.OnLocationChanged += p3.Run;

            b1.OnLocationChanged += p5.Run;
            b1.OnLocationChanged += p6.Run;
            b1.OnLocationChanged += p7.Run;

            b1.OnLocationChanged += ref1.Look;


            b1.BallLocation = new Location() { X=10,Y=20,Z=30};

            Console.WriteLine("=============== New Location ===============");
            b1.BallLocation = new Location() { X=15,Y=25,Z=35};

            Console.WriteLine(p1.Location);
        }
    }
}
