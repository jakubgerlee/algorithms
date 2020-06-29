namespace LinqPlayground.Models
{
	public class Person
	{
		public Person(string name, int money, int weight, Gender gender, string city)
		{
			Name = name;
			Money = money;
			Weight = weight;
			Gender = gender;
			City = city;
		}

		public string Name { get; set; }
		public int Money { get; set; }
		public int Weight { get; set; }
		public string City { get; set; }
		public Gender Gender { get; set; }
	}
}
