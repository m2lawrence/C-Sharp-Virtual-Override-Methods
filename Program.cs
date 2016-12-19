//Reusing Existing Code with Inheritance, day 10. Using Virtual Methods.
// A virtual method enables you to call the method associated with the actual 
//assigned type (new copied one) rather than the base class type.
using System;

namespace Inherit04VirtualM
{
	class Person
	{
		//protected means: this class and only the dervived classes below can see it.
		protected string firstName;
		protected string lastName;
			
		public Person() 
		{
		}
		
		public Person(string fn, string ln)
		{
			firstName = fn;
			lastName = ln;
		}
		
		//virtual is an indicator that if the data assigned to a
		//Person object is from a derived class,
		//the derived class's method should be used instead. 
		public virtual void displayFullName()
		{
			Console.WriteLine("{0} {1}", firstName, lastName); 
		}
	}
	
	//Derived class, inherits the base class.
	class Employee : Person
	{
		public ushort hireYear;
		
		public Employee() : base()
		{
		}
		
		public Employee(string fn, string ln, ushort hy) : base(fn, ln)
		{
			hireYear = hy;
		}
		
		//override: indicates that for any data of the Employee type, 
		//this specific version of the displayFullName() should be used. 
		public override void displayFullName()
		{
			Console.WriteLine("Employee: {0} {1}", firstName, lastName); 
		}
	}
	
	//A new class derived from Person.
	class Contractor : Person
	{
		public string company;
		
		public Contractor() : base()
		{
		}
		
		public Contractor(string fn, string ln, string c) : base(fn, ln)
		{
			company = c;
		}
		
		//Override: Indicates that the person is a contractor. 
		public override void displayFullName()
		{
			Console.WriteLine("Contractor: {0} {1}", firstName, lastName); 
		}
	}
	
	class NameApp
	{
		//computer starts running programme from the main() here.
		public static void Main()
		{
			//class object =new class(), builds  x3 objects of type Person, 
			//assigns a different data object (Per,Emp,Con), and then assigns some values (names).
			Person Mike = new Person("Michael", "Lawrence");
			Person me = new Employee("Michael", "Lawrence", 2017);
			Person worker = new Contractor("Carolyn", "China", "UStorIT");
			
			Mike.displayFullName();
			me.displayFullName();
			worker.displayFullName();
			
			Console.ReadKey(true);
		}
	}
} 