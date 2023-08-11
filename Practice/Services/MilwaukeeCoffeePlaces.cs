using System;
using System.Collections.Generic;
using Practice.Models;

namespace Practice.Services
{
	public class MilwaukeeCoffeePlaces
	{

		readonly List<Coffee> coffees = new List<Coffee>();
		public MilwaukeeCoffeePlaces()
		{

			coffees.Add(new Coffee("Starbucks", "Latte"));
			coffees.Add(new Coffee("JavaDen", "Capuccino"));
			coffees.Add(new Coffee("Blum", "Americano"));

		}

		public List<Coffee> addCoffee(Coffee coffee)
		{
			coffees.Add(coffee);
			return coffees;
		}

		public List<Coffee> removeCoffee(Coffee coffee)
		{
			coffees.Remove(coffee);
			return coffees;
		}

	}
}

