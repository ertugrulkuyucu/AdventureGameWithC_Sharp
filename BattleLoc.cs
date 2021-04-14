using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    public class BattleLoc : Location
    {
		protected Obstacle obstacle;
		protected String award;

		public BattleLoc(Player player, String name, Obstacle obstacle, String award) : base(player)
		{
			
			this.obstacle = obstacle;
			this.name = name;
			this.award = award;
		}

		override public bool getLocation()
		{
			int obsCount = obstacle.count();
			Console.WriteLine("Suan buradasiniz : " + this.getName());
			Console.WriteLine("Dikkatli ol! Burada " + obsCount + " tane " + obstacle.getName() + " yasiyor !");
			Console.WriteLine("<S>avas veya <K>aç :");
			String selCase = Console.ReadLine();
			selCase = selCase.ToUpper();
			if (selCase.Equals("S"))
			{
				if (combat(obsCount))
				{
					Console.WriteLine(this.getName() + " bölgesindeki tüm düsmanlari temizlediniz !");
					if (this.award.Equals("Food") && player.getInv().isFood() == false)
					{
						Console.WriteLine(this.award + " Kazandiniz! ");
						player.getInv().setFood(true);
					}
					else if (this.award.Equals("Water") && player.getInv().isWater() == false)
					{
						Console.WriteLine(this.award + " Kazandiniz! ");
						player.getInv().setWater(true);
					}
					else if (this.award.Equals("Firewood") && player.getInv().isFirewood() == false)
					{
						Console.WriteLine(this.award + " Kazandiniz! ");
						player.getInv().setFirewood(true);
					}
					return true;
				}

				if (player.getHealthy() <= 0)
				{
					Console.WriteLine("Öldünüz !");
					return false;
				}

			}
			return true;
		}

		public bool combat(int obsCount)
		{
			for (int i = 0; i < obsCount; i++)
			{
				int defObsHealth = obstacle.getHealth();
				playerStats();
				enemyStats();
				while (player.getHealthy() > 0 && obstacle.getHealth() > 0)
				{
					Console.WriteLine("<V>ur veya <K>aç :");
					String selCase = Console.ReadLine();
					selCase = selCase.ToUpper();
					if (selCase.Equals("V"))
					{
						Console.WriteLine("Siz vurdunuz !");
						obstacle.setHealth(obstacle.getHealth() - player.getTotalDamage());
						afterHit();
						if (obstacle.getHealth() > 0)
						{
							Console.WriteLine();
							Console.WriteLine("Canavar size vurdu !");
							player.setHealthy(player.getHealthy() - (obstacle.getDamage() - player.getInv().getArmor()));
							afterHit();
						}
					}
					else
					{
						return false;
					}
				}

				if (obstacle.getHealth() < player.getHealthy())
				{
					Console.WriteLine("Düsmani yendiniz !");
					player.setMoney(player.getMoney() + obstacle.getAwardMoney());
					Console.WriteLine("Güncel Paraniz : " + player.getMoney());
					obstacle.setHealth(defObsHealth);
				}
				else
				{
					return false;
				}
				Console.WriteLine("-------------------");
			}
			return true;
		}

		public void playerStats()
		{
			Console.WriteLine("Oyuncu Degerleri\n--------------");
			Console.WriteLine("Can:" + player.getHealthy());
			Console.WriteLine("Hasar:" + player.getTotalDamage());
			Console.WriteLine("Para:" + player.getMoney());
			if (player.getInv().getDamage() > 0)
			{
				Console.WriteLine("Silah:" + player.getInv().getwName());
			}
			if (player.getInv().getArmor() > 0)
			{
				Console.WriteLine("Zirh:" + player.getInv().getaName());
			}
		}

		public void enemyStats()
		{
			Console.WriteLine("\n" + obstacle.getName() + " Degerleri\n--------------");
			Console.WriteLine("Can:" + obstacle.getHealth());
			Console.WriteLine("Hasar:" + obstacle.getDamage());
			Console.WriteLine("Ödül:" + obstacle.getAwardMoney());
		}

		public void afterHit()
		{
			Console.WriteLine("Oyuncu Cani:" + player.getHealthy());
			Console.WriteLine(obstacle.getName() + " Cani:" + obstacle.getHealth());
			Console.WriteLine();
		}
	}
}
