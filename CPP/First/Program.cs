﻿using System;

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
	}
}
