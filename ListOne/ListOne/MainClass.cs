namespace ListOne
{
	internal class MainClass
	{
		private Person _person;

		List<Person> _list;

		public void Start()
		{
			_list = new List<Person>();
		}

		public void Update()
		{
            Console.WriteLine("Enter command");
            string commands = Console.ReadLine();

			StreamWriter sw;
			StreamReader sr;

			string[] commandsArray = new string[]
			{
				"create file",
				"clear",
				"add person"
			};

			if (commands == commandsArray[0])
			{
				Console.WriteLine("Enter name file");
				string nameFile = Console.ReadLine();
				sw = new StreamWriter($"{nameFile}.txt", true);
				sw.Close();
			}
			else if (commands == commandsArray[2])
			{
				Person person;
                Console.WriteLine("Enter first name");
				string firstName = Console.ReadLine();
				Console.WriteLine("Enter last name");
				string lastName = Console.ReadLine();
				Console.WriteLine("Enter age person");
				byte age = byte.Parse(Console.ReadLine());
				Console.WriteLine("Enter preferences");
				string preferences = Console.ReadLine();
				Console.WriteLine("Enter data arrival (year, month, day)");
				
				DateTime dateArrival;
                int yearArrival = int.Parse(Console.ReadLine());
				int monthArrival = int.Parse(Console.ReadLine());
				int dayArrival = int.Parse(Console.ReadLine());
				dateArrival = new DateTime(yearArrival, monthArrival, dayArrival);

				Console.WriteLine("Enter data arrival (year, month, day)");
				DateTime dateDeparture;
				int yearDeparture = int.Parse(Console.ReadLine());
				int monthDeparture = int.Parse(Console.ReadLine());
				int dayDeparture = int.Parse(Console.ReadLine());
				dateDeparture = new DateTime(yearDeparture, monthDeparture, dayDeparture);
				person = new Person(firstName, lastName, age, preferences, dateArrival, dateDeparture);

				Console.WriteLine("Enter name file");
				string nameFile = Console.ReadLine();
				sw = new StreamWriter($"{nameFile}.txt", false);
				sw.WriteLine($"{person.FirstName}\n{person.LastName}\n{person.Age}\n{person.Preferences}\n" +
					$"Date arrival - {person.DateArrival}, Date departure - {person.DateDeparture}");
			}
		}
	}
}
