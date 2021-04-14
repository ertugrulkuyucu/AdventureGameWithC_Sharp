using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    public class Obstacle
    {
		private String name;
		private int damage, health, awardMoney, maxNumber;
		public Obstacle(String name, int damage, int health, int award, int maxNumber)
		{
			this.name = name;
			this.damage = damage;
			this.health = health;
			this.awardMoney = award;
			this.maxNumber = maxNumber;
		}
		public int count()
		{
			Random r = new Random();
			return r.Next(this.maxNumber) + 1;
		}
		public String getName()
		{
			return name;
		}
		public void setName(String name)
		{
			this.name = name;
		}
		public int getDamage()
		{
			return damage;
		}
		public void setDamage(int damage)
		{
			this.damage = damage;
		}
		public int getHealth()
		{
			return health;
		}
		public void setHealth(int health)
		{
			this.health = health;
		}
		public int getAwardMoney()
		{
			return awardMoney;
		}
		public void setAward(int award)
		{
			this.awardMoney = award;
		}
		public int getMaxNumber()
		{
			return maxNumber;
		}
		public void setMaxNumber(int maxNumber)
		{
			this.maxNumber = maxNumber;
		}


	}
}
