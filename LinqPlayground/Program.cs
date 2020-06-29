using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Models;

namespace LinqPlayground
{
	class Program
	{
		private static int _counter = 0;
		private static string _sentence = "I love dogs";
		private static string[] _dogNames = { "Bruce", "John", "Valdo", "Santi", "Maria", "Joe", "Vadim", "Santana", "Ezero" };
		private static int[] _numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

		static void Main(string[] args)
		{
			JoinOperations();
			//LinqOperationPlayground();
			//LinqOperation();
		}

		private static void JoinOperations()
		{
			var buyers = new List<Buyer>
			{
				new Buyer {Name = "Johny", Age = 22, District = "Gdansk"},
				new Buyer {Name = "Ada", Age = 40, District = "Sopot"},
				new Buyer {Name = "Jan", Age = 35, District = "Gdansk"},
				//new Buyer {Name = "Mario", Age = 40, District = "Sopot"},
				//new Buyer {Name = "Johny", Age = 22, District = "Gdansk"},
			};

			var suppliers = new List<Supplier>
			{
				new Supplier{Name = "Jakub", Age = 35, District = "Sopot"},
				new Supplier{Name = "Valdo", Age = 22, District = "Gdansk"},
				new Supplier{Name = "Halina", Age = 40, District = "Sopot"},
				new Supplier{Name = "Eustachy", Age = 35, District = "Gdansk"},
				new Supplier{Name = "Warek", Age = 22, District = "Sopot"},
				new Supplier{Name = "Eustachy", Age = 35, District = "Gdynia"},
			};






			var suppliersForBuyers =
				from b in buyers
				join s in suppliers on b.District equals s.District
				group b by b.District
				into v
				select new
				{
					Name = v.Key,
					Count = v.Key.Sum(x => x)
				};

			foreach (var suppliersForBuyer in suppliersForBuyers)
			{
				Console.WriteLine($"{suppliersForBuyer.Name} {suppliersForBuyer.Count}");
			}






			//find buyers and suppliers from the same district

			//var innerJoin =
			//	from s in suppliers
			//	orderby s.District
			//	join b in buyers on s.District equals b.District
			//	select new
			//	{
			//		SupplierName = s.Name,
			//		BuyerName = b.Name,
			//		District = s.District
			//	};


			//foreach (var @object in innerJoin)
			//{
			//	Console.WriteLine($"District: {@object.District} Buyer: {@object.BuyerName} Supplier: {@object.SupplierName}");
			//}
		}

		private static void LinqOperation()
		{
			var persons = new List<Person>
			{
				new Person("Tod", 180, 70, Gender.Male, "Gdansk"),
				new Person("Tad", 180, 70, Gender.Male, "Sopot"),
				new Person("John", 170, 88, Gender.Male, "Sopot"),
				new Person("Anna", 150, 48, Gender.Female, "Gdansk"),
				new Person("Kyle", 164, 78, Gender.Male, "Gdansk"),
				new Person("Krisinele", 164, 76, Gender.Male, "Gdansk"),
				new Person("Tod", 164, 79, Gender.Male, "Gdansk"),
				new Person("Annna", 160, 55, Gender.Female, "Warszawa"),
				new Person("Maria", 160, 55, Gender.Female, "Gdansk"),
				new Person("CJ", 120, 35, Gender.Other, "Gdansk"),
			};


			var genderMaleGroup = persons.Where(x => x.Gender == Gender.Male).Select(x => x);


			foreach (var male in genderMaleGroup)
			{
				Console.WriteLine(male.Name + " " + male.Gender);
			}

			var personsWithFourCharactersName1 = persons.Select(x => x)
				.Where(y => y.Name.Length == 4)
				.OrderBy(x => x.Weight);

			var nameWithFourCharacterNameOrderedByWeight = persons.Select(x => x)
				.Where(y => y.Name.Length == 4)
				.OrderBy(x => x.Weight)
				.Select(x => x.Name);


			var personsWithFourCharactersName3 =
				from p in persons
				where p.Name.Length == 4
				orderby p.Name descending, p.Money ascending
				select p;


			foreach (var person in personsWithFourCharactersName1)
			{
				Console.Write($"{person.Name} weight {person.Weight}\n");
			}

			Console.WriteLine("\n");

			foreach (var name in nameWithFourCharacterNameOrderedByWeight)
			{
				Console.Write(name + " ");
			}
		}

		private static void LinqOperationPlayground()
		{
			var evenNumbers = _numbers.Where(x => x % 2 == 0)
				.Distinct()
				.OrderBy(x => x);

			var oodNumbers = _numbers.Where(x => x % 2 == 1)
				.Distinct()
				.OrderByDescending(x => x);

			Console.WriteLine(string.Join(", ", evenNumbers) + "\n");
			Console.WriteLine(string.Join(", ", oodNumbers) + "\n");

			var persons = new List<Person>
			{
				new Person("Tod", 180, 70, Gender.Male, "Gdansk"),
				new Person("Tod", 180, 70, Gender.Male, "Sopot"),
				new Person("John", 170, 88, Gender.Male, "Sopot"),
				new Person("Kyle", 150, 48, Gender.Female, "Gdansk"),
				new Person("Kyle", 164, 78, Gender.Female, "Gdansk"),
				new Person("Krisinele", 164, 76, Gender.Male, "Gdansk"),
				new Person("Tod", 164, 79, Gender.Male, "Gdansk"),
				new Person("Annna", 160, 55, Gender.Female, "Warszawa"),
				new Person("Maria", 160, 55, Gender.Female, "Gdansk"),
				new Person("CJ", 120, 35, Gender.Other, "Gdansk"),
			};


			var moneyPerPerson = persons
				.GroupBy(x => x.Name)
				.Select(x => new { Name = x.Key, AmountOfMoney = x.Sum(a => a.Money) });

			foreach (var money in moneyPerPerson)
			{
				Console.WriteLine($"{money.Name} {money.AmountOfMoney}");
			}








			var nameGroup = persons
				.OrderBy(x => x.City)
				.GroupBy(p => new { p.Name })
				.Select(a => new { AmountMoney = a.Sum(b => b.Money), Name = a.Key });

			foreach (var gender in nameGroup)
			{
				Console.WriteLine($"{gender.Name},{gender.AmountMoney}");

			}
		}

		private static IEnumerable<string> DogsStartWithA2(string[] dogNames, out IEnumerable<string> dogsStartWithA)
		{
			var dogsStartWithA2 = dogNames.Where(x => x.Contains("a"));
			dogsStartWithA = from dog in dogNames
							 where dog.Contains("a") && dog.Length > 5
							 select dog;
			return dogsStartWithA2;
		}

		private static IOrderedEnumerable<int> OrderedEnumerable(int[] numbers, out IOrderedEnumerable<int> sortedNumbers2)
		{
			var sortedNumbers = numbers.Where(x => x > 50).OrderBy(x => x);
			sortedNumbers2 = from num in numbers
							 where (num > 50)
							 orderby num descending
							 select num;
			return sortedNumbers;
		}

		private static void Print(IEnumerable input)
		{
			Console.WriteLine($"\n{_counter}. LIST");
			foreach (var iterator in input)
			{
				Console.Write(iterator + " ");
			}
			_counter++;
		}
	}
}
