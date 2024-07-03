using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb11Ball
{

    public class BallLocationChangedEventArgs : EventArgs
    {
        public Location NewLocation { get; set; }
    }
}
