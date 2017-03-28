using System;
namespace First
{
	public class Samochody
	{
		public string kolor = "";
		public int rok_prod;
		public float przebieg;
		private bool moving;

		public bool move()
		{
			Console.WriteLine("Ruszam");
			return moving = true;
		}

		public bool stop()
		{
			Console.WriteLine("Zatrzymuje");
			return moving = false;
		}

		public void is_moving()
		{
			if (moving)
			{
				Console.WriteLine("Samochod porusza sie");
			}
			else if (!moving) Console.WriteLine("Samochod nie porusza sie");
		}
	}
}
