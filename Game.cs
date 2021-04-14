using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
	class Game
	{
		Player player;
		Location location;

		public void login()
		{
			Console.WriteLine("Macera Oyununa Hosgeldiniz !");
			Console.WriteLine("Oyuna baslamadan önce isminizi giriniz :");
			String playerName = Console.ReadLine();
			player = new Player(playerName);
			player.selectChar();
			start();
		}

		public void start()
		{
			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("=================================================");
				Console.WriteLine();
				Console.WriteLine("Eylem gerçeklestirmek için bir yer seçiniz : ");
				Console.WriteLine("1. Güvenli Ev --> Size ait güvenli bir mekan, düsman yok!");
				Console.WriteLine("2. Magara --> Karsiniza zombi çikabilir!");
				Console.WriteLine("3. Orman --> Karsiniza vampir çikabilir!");
				Console.WriteLine("4. Nehir --> Karsiniza ayi çikabilir!");
				Console.WriteLine("5. Magaza --> Silah veya Zirh alabilirsiniz!");
				Console.WriteLine("Gitmek istediginiz yer : ");
				int selLoc = Convert.ToInt32(Console.ReadLine());
				while (selLoc < 0 || selLoc > 5)
				{
					Console.WriteLine("Lütfen geçerli bir yer seçiniz : ");
					selLoc = Convert.ToInt32(Console.ReadLine());
				}

				switch (selLoc)
				{
					case 1:
						location = new SafeHouse(player);
						break;
					case 2:
						location = new Cave(player);
						break;
					case 3:
						location = new Forest(player);
						break;
					case 4:
						location = new River(player);
						break;
					case 5:
						location = new ToolStore(player);
						break;
					default:
						location = new SafeHouse(player);
						break;
				}

				if (location.getName() == "Guvenli Ev")
				{
					if (player.getInv().isFirewood() && player.getInv().isFood() && player.getInv().isWater())
					{
						Console.WriteLine("Tebrikler Oyunu Kazandiniz!");
						break;
					}
				}
				if (!location.getLocation())
				{
					Console.WriteLine("Oyun Bitti!");
					break;
				}

			}

		}
	}
}
