namespace ListOne
{
	internal class MainClass
	{
		private Person _person;
		private MathOperations _mathOperations;

		List<Person> _list;

		int width = 30;
		int height = 30;

		public void Start()
		{
			_list = new List<Person>();
			_mathOperations = new MathOperations();
			Console.SetWindowSize(width, height);
		}

		public void Update()
		{
			string[] commandsArray = new string[]
			{
				"create file",
				"start operations",
				"clear",
				"add person",
				"open file",
				"exit"
			};
            
			StreamWriter sw;
			StreamReader sr;
			bool flag = false;
			while (flag != true)
			{
				try
				{
					Console.WriteLine("Enter command");
					string commands = Console.ReadLine();
					if (commands == commandsArray[0])
					{
						Console.WriteLine("Enter name file");
						string nameFile = Console.ReadLine();
						sw = new StreamWriter($"{nameFile}.txt", true);
						sw.Close();
					}
					else if (commands == commandsArray[1])
					{
						_mathOperations.UpdateMathOperation();
					}
					else if (commands == commandsArray[2])
					{
						Console.Clear();
					}
					else if (commands == commandsArray[3])
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
						_list.Add(person);

						Console.WriteLine("Enter name file");
						string nameFile = Console.ReadLine();
						sw = new StreamWriter($"{nameFile}.txt", false);
						sw.WriteLine($"{person.FirstName}\n{person.LastName}\n{person.Age}\n{person.Preferences}\n" +
							$"Date arrival - {person.DateArrival}, Date departure - {person.DateDeparture}", false);
						sw.Close();
					}
					else if (commands == commandsArray[4])
					{
						Console.WriteLine("Enter name file");
						string nameFile = Console.ReadLine();
						sr = new StreamReader($"{nameFile}.txt", true);
						string text = sr.ReadToEnd();
						Console.WriteLine($"Data person - {text}");
					}
					else if (commands == commandsArray[5])
					{
						flag = true;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);;
				}
			}
		}
	}
}
