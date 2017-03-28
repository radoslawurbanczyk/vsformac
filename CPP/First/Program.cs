using System;

namespace First
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			MainClass FirstInstance = new MainClass();
			FirstInstance.Display();
			Console.WriteLine(FirstInstance.CountSum(4, 5));
			int substaction = FirstInstance.CountSubstract(6, 8);
			Console.WriteLine(substaction);
			FirstInstance.TabliczkaMnozenia();
			Samochody fiat;
			fiat = new Samochody();
			fiat.przebieg = 10000;
			Console.WriteLine(fiat.przebieg.ToString());
			Console.WriteLine(fiat.kolor.ToString());
			Console.WriteLine(fiat.rok_prod.ToString());
			//Console.WriteLine(fiat.moving.ToString());
			fiat.is_moving();
			fiat.move();
			fiat.is_moving();
			fiat.stop();
			fiat.is_moving();

			int max = FirstInstance.wybierz_max(1, 1, 8);
			Console.WriteLine(max);
		}

		public void Display()
		{
			Console.WriteLine("cokolwiek");
		}

		public int CountSum(int a, int b)
		{
			return a + b;
		}

		public int CountSubstract(int a, int b)
		{
			return b - a;
		}

		public void TabliczkaMnozenia()
		{
			for (int i = 1; i <= 10; i++)
			{
				for (int j = 1; j <= 10; j++)
				{
					int iloczyn = i * j;
					Console.Write(((iloczyn < 100) ? " " : "") + ((iloczyn<10) ? " " : "") + iloczyn + ((j < 10) ? " " : ""));
				}
				Console.WriteLine();
			}
		}

		public int wybierz_max(int a, int b, int c)
		{
			if (a<=0 || b<=0 || c<=0)
			{
				Console.WriteLine("Podano wartości ujemne. Popraw!");
				return 0;
			}
			else
			{
				if (a > b && a > c)
				{
					return a;
				}
				else if (b > a && b > c)
				{
					return b;
				}
				else
				{
					return c;
				}
			}
		}
	}
}
