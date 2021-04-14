using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    public class Inventory
    {
		private bool water, food, firewood;
		private String wName, aName;
		private int damage, armor;

		public Inventory()
		{
			this.water = false;
			this.food = false;
			this.firewood = false;
			this.damage = 0;
			this.armor = 0;
			this.wName = null;
			this.aName = null;
		}

		public bool isWater()
		{
			return water;
		}

		public void setWater(bool water)
		{
			this.water = water;
		}

		public bool isFood()
		{
			return food;
		}

		public void setFood(bool food)
		{
			this.food = food;
		}

		public bool isFirewood()
		{
			return firewood;
		}

		public void setFirewood(bool firewood)
		{
			this.firewood = firewood;
		}

		public String getwName()
		{
			return wName;
		}

		public void setwName(String wName)
		{
			this.wName = wName;
		}

		public String getaName()
		{
			return aName;
		}

		public void setaName(String aName)
		{
			this.aName = aName;
		}

		public int getDamage()
		{
			return damage;
		}

		public void setDamage(int damage)
		{
			this.damage = damage;
		}

		public int getArmor()
		{
			return armor;
		}

		public void setArmor(int armor)
		{
			this.armor = armor;
		}
	}
}
