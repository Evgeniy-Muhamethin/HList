using System;

namespace ListOne
{
	/// <summary>
	/// first name 
	/// last name
	/// age
	/// preferences
	/// data arrival
	/// data departure
	/// </summary>
	internal class Person
	{
		private string firstName;
		private string lastName;
		private byte age;
		private string preferences;
		private DateTime dateArrival;
		private DateTime dateDeparture;

		public string FirstName { get { return firstName; } set { firstName = value; } }
		public string LastName { get { return lastName; } set { lastName = value; } }
		public byte Age { get { return age;} set { age = value; } }
		public string Preferences { get { return preferences; } set { preferences = value; } }
		public DateTime DateArrival { get {  return dateArrival; } set {  dateArrival = value; } }
		public DateTime DateDeparture { get {  return dateDeparture; } set { dateDeparture = value; } }

		public Person(string firstName, string lastName, byte age, string preferences, 
			DateTime dateArrival, DateTime dataDeparture) 
		{ 
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.preferences = preferences;
			this.dateArrival = dateArrival;
			this.dateDeparture = dataDeparture;
		}

		public override string ToString()
		{
			return $"{FirstName},\n {LastName},\n {Age},\n {Preferences},\n {DateArrival},\n {DateDeparture}";
		}
	}
}
