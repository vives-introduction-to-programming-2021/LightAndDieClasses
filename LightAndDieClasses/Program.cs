using System;

namespace LightAndDieClasses
{
    class Program
    {
        static void Main(string[] args)
		{
			Console.WriteLine("Hello World");

			int x = 15;
			Light kitchen = new Light();
			// Light ceiling = kitchen;

			Console.WriteLine("Kitchen Light? " + kitchen.isOn);

			Light garage = new Light();     // 2de object !
			garage.On();

			Console.WriteLine("Kitchen Light? " + kitchen.isOn);
			Console.WriteLine("Garage Light? " + garage.isOn);

			// We can throw single die as many times as we want
			Die six = new Die();
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"You threw: {six.Roll()}");
			}

			Console.WriteLine("");

			Die twenty = new Die();
			twenty.SetNumberOfEyes(20);
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"You threw: {twenty.Roll()}");
			}
		}
    }
}
