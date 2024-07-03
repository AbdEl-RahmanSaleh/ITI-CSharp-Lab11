namespace Labb11Ball
{
    public class Ball
    {
        public int Id { get; set; }
		private Location ballLocation;

		public Location BallLocation
		{
			get => ballLocation; 
			set {

                if (value != ballLocation)
                {
                    ballLocation = value;
                    OnLocationChanged?.Invoke(value,new BallLocationChangedEventArgs { NewLocation = value});
                }
            }
        }

        public event EventHandler<BallLocationChangedEventArgs>? OnLocationChanged;



        public override string ToString() => $"{Id} , {ballLocation}";
        
    }
}
