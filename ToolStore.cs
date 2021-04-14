using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    class ToolStore : NormalLoc
    {

		public ToolStore(Player player) : base (player, "Magaza")
		{
		}

		override public bool getLocation()
		{
			Console.WriteLine("Para : " + player.getMoney());
			Console.WriteLine("1. Silahlar");
			Console.WriteLine("2. Zirhlar");
			Console.WriteLine("3. Magazadan Cik");
			Console.WriteLine("Seciminiz : ");
			int chooseStore = Convert.ToInt32(Console.ReadLine());
			int chooseID;
			switch (chooseStore)
			{

				case 1:
					chooseID = weaponMenu();
					buyWeapon(chooseID);
					break;

				case 2:
					chooseID = armorMenu();
					buyArmor(chooseID);
					break;

				case 3:
					break;

				default:
					Console.WriteLine("Gecersiz islem...");
					break;
			}
			return true;
		}

		public int weaponMenu()
		{
			Console.WriteLine("1. Tabanca < Hasar : 2 - Para : 25 >");
			Console.WriteLine("2. Kilic   < Hasar : 3 - Para : 35 >");
			Console.WriteLine("3. Tüfek   < Hasar : 7 - Para : 45 >");
			Console.WriteLine("4. Geri");
			Console.WriteLine("Seciminiz : ");
			int chooseWeapon = Convert.ToInt32(Console.ReadLine());
			return chooseWeapon;
		}

		public void buyWeapon(int itemID)
		{
			int damage = 0, price = 0;
			String wName = null;
			switch (itemID)
			{
				case 1:
					damage = 2;
					price = 15;
					wName = "Tabanca";
					break;
				case 2:
					damage = 3;
					price = 35;
					wName = "Kilic";
					break;
				case 3:
					damage = 7;
					price = 45;
					wName = "Tüfek";
					break;
				case 4:
					getLocation();
					break;
				default:
					Console.WriteLine("Gecersiz islem !");
					break;
			}

			if (price > 0)
			{
				if (player.getMoney() >= price)
				{
					player.getInv().setDamage(damage);
					player.getInv().setwName(wName);
					player.setMoney(player.getMoney() - price);
					Console.WriteLine(wName + " satin aldiniz. Yine bekleriz. :)");
					Console.WriteLine("Kalan paraniz : " + player.getMoney());
					Console.WriteLine("Yeni toplam hasariniz : " + player.getTotalDamage());
				}
				else
				{
					Console.WriteLine("Yetersiz bakiye..");
				}
			}
		}

		public int armorMenu()
		{
			Console.WriteLine("1. Hafif Zirh  < Engel  : 1 - Para : 15 >");
			Console.WriteLine("2. Orta  Zirh  < Engel  : 3 - Para : 25 >");
			Console.WriteLine("3. Agir  Zirh  < Engel  : 5 - Para : 40 >");
			Console.WriteLine("4. Geri");
			Console.WriteLine("Seciminiz : ");
			int chooseArmor = Convert.ToInt32(Console.ReadLine());
			return chooseArmor;
		}

		public void buyArmor(int itemID)
		{

			int avoid = 0, price = 0;
			String aName = null;
			switch (itemID)
			{
				case 1:
					avoid = 1;
					price = 15;
					aName = "Hafif Zirh";
					break;
				case 2:
					avoid = 3;
					price = 25;
					aName = "Orta Zirh";
					break;
				case 3:
					avoid = 5;
					price = 40;
					aName = "Agir Zirh";
					break;
				case 4:
					getLocation();
					break;
				default:
					Console.WriteLine("Geçersiz islem !");
					break;
			}

			if (price > 0)
			{
				if (player.getMoney() >= price)
				{
					player.getInv().setArmor(avoid);
					player.getInv().setaName(aName);
					player.setMoney(player.getMoney() - price);
					Console.WriteLine(aName + " satin aldiniz. Yine bekleriz. :)");
					Console.WriteLine("Kalan paraniz : " + player.getMoney());
				}
				else
				{
					Console.WriteLine("Yetersiz bakiye..");
				}
			}
		}

	}
}
