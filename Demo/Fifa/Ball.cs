using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }

		private Location location;

       public List<Player> Players { get; set; } = new List<Player>();
        public List<Refere> referes { get; set; } = new List<Refere>();
        public Location Location
		{
			get { return location; }
			set 
            {
                foreach (var player in Players)
                {
                    player.Run(this);
                }
                foreach (var refere  in referes)
                {
                    refere.Look(this);
                }
                location = value;
            }
		}

        public override string ToString()
        {
            return $"id : {Id} , Location : {Location}";
        }

    }
}
