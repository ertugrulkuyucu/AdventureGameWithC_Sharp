﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    public abstract class Location
    {
		protected Player player;
		protected String name;

		public Location(Player player)
		{
			this.player = player;
		}

		public abstract bool getLocation();

		public Player getPlayer()
		{
			return player;
		}

		public void setPlayer(Player player)
		{
			this.player = player;
		}

		public String getName()
		{
			return name;
		}

		public void setName(String name)
		{
			this.name = name;
		}

	}
}
