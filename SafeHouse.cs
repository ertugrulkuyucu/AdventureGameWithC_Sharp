using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    public class SafeHouse : NormalLoc
    {
		public SafeHouse(Player player) : base(player, "Guvenli Ev")
		{
		}

		override public bool getLocation()
		{		
			player.setHealthy(player.getFirstHealthy());
			Console.WriteLine("Caniniz fullendi.");
			Console.WriteLine("Suan Güvenli evdesiniz..");
			return true;
		}
	}
}
