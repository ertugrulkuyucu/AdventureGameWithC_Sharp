using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    public class Player
    {
        private int damage, healthy, money, rHealthy;
        private String name, cName;
        private Inventory inv;
        

     public Player(String name)
        {
            this.name = name;
            this.inv = new Inventory();
        }

        public void selectChar()
        {
            switch(charMenu())
            {
                case 1 :
                    initPlayer("Samuray", 5, 21, 15);
                    break;
                case 2:
					initPlayer("Okcu", 7, 18, 20);
                    break;
                case 3:
                    initPlayer("Sovalye", 8, 24, 5);
                    break;
                default:
                    initPlayer("Samuray", 5, 21, 15);
                    break;
            }
            Console.WriteLine("Karakter Olusturuldu! Adi=" + getcName() + " ,Hasar=" + getDamage() + " ,Saglik="
                + getHealthy() + " ,Para=" + getMoney());
        }

		public int charMenu()
		{
			Console.WriteLine("Lütfen bir karakter seciniz : ");
			Console.WriteLine("1- Samuray \t Hasar : 5 \t Saglik :21 \t Para :15");
			Console.WriteLine("2- Okcu \t Hasar : 7 \t Saglik :18 \t Para :20");
			Console.WriteLine("3- Sovalye \t Hasar : 8 \t Saglik :24 \t Para :5");
			Console.WriteLine("Karater Seciminiz : ");
			int chaID = Convert.ToInt32(Console.ReadLine());

			while (chaID < 1 || chaID > 3)
			{
				Console.WriteLine("Lütfen gecerli bir karakter seciniz : ");
				chaID = Convert.ToInt32(Console.ReadLine());
			}
			return chaID;
		}

		public int getTotalDamage()
		{
			return this.getDamage() + this.getInv().getDamage();
		}

		public void initPlayer (String cName, int damage, int healthy, int money)
        {
			setcName(cName);
			setDamage(damage);
			setHealthy(healthy);
			setMoney(money);
			setFirstHealthy(healthy);
		}

		public int getDamage()
		{
			return damage;
		}

		public void setDamage(int damage)
		{
			this.damage = damage;
		}

		public int getHealthy()
		{
			return healthy;
		}

		public void setHealthy(int healthy)
		{
			this.healthy = healthy;
		}

		public int getMoney()
		{
			return money;
		}

		public void setMoney(int money)
		{
			this.money = money;
		}

		public String getName()
		{
			return name;
		}

		public void setName(String name)
		{
			this.name = name;
		}

		public String getcName()
		{
			return cName;
		}

		public void setcName(String cName)
		{
			this.cName = cName;
		}

		public Inventory getInv()
		{
			return inv;
		}

		public void setInv(Inventory inv)
		{
			this.inv = inv;
		}

		public int getFirstHealthy()
		{
			return rHealthy;
		}

		public void setFirstHealthy(int rHealthy)
		{
			this.rHealthy = rHealthy;
		}



	}
}
