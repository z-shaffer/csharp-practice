using System;
					
public class Program
{
	public static void Main()
	{
		var menu = "";
		var submenu = "C";
		while (submenu == "C")
		{
			while (menu != "K1" && menu != "K2" && menu != "E")
			{
				Console.WriteLine("Please pick a category: 'K1', 'K2', or 'E' to end.");
				menu = Console.ReadLine();
			}
			if (menu == "E")
			{
				Environment.Exit(1);
			}
			submenu = "";
			while (submenu != "C")
			{
				Console.WriteLine("Which submenu option do you want?");
				Console.WriteLine("(A) Einzelwert");
				Console.WriteLine("(B) Kostenubersicht");
				Console.WriteLine("(C) Kategorie andern");
				submenu = Console.ReadLine();
				if (submenu == "A")
				{
					Console.WriteLine("Please enter the distance in KM:");
					double distance = Convert.ToDouble(Console.ReadLine());
					if (menu == "K1")
					{
						double cost = (distance * 0.42) + 90;
						Console.WriteLine("Cost : " + cost + "EUR");
					}
					else if (menu == "K2")
					{
						if (distance > 100)
						{
							distance = distance - 100;
							double cost = (distance * 0.17) + 99;
							Console.WriteLine("Cost : " + cost + "EUR");
						}
						else
						{
							Console.WriteLine("Cost : 99 EUR");
						}
					}
				}
				else if (submenu == "B")
				{
					Console.WriteLine("Please enter the max distance in KM:");
					double maxDistance = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Please enter the incrementing distance in KM:");
					double incDistance = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Gefahrene Kilometer {0, 10}", "Preis");
					for (double i = 0; i <= maxDistance; i += incDistance)
					{
						if (menu == "K1")
						{
							double cost = (i * 0.42) + 90;
							Console.WriteLine(i + "{0, 37} EUR", cost.ToString("F"));
						}
						else if (menu == "K2")
						{
							if (i > 100)
							{
								double cost = ((i - 100) * 0.17) + 99;
								Console.WriteLine(i + "{0, 37} EUR", cost.ToString("F"));
							}
							else
							{
								Console.WriteLine(i + "{0, 37} EUR", "99,00");
							}
						}
					}
				}
				else if (submenu == "C")
				{
					menu = "";
				}
			}
		}
	}
}