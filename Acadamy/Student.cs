using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	internal class Student: Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attendace { get; set; }

		public Student(
			string lastName, string firstName, int age, 
			string specoality, string group, double rating, double attendace
			):base(lastName, firstName, age)
		{
			Speciality = specoality;
			Group = group;
			Rating = rating;
			Attendace = attendace;
            //Console.WriteLine("SConstructor: " + GetHashCode());
		}
		~Student() 
		{
            //Console.WriteLine("SDestructor: " + GetHashCode());
		}
		public void Print()
		{
			base.Print();
            Console.WriteLine(Speciality + " " +  Group + " " +  Rating + " " + Attendace);
		}
		public override string ToString()
		{
			return "Student: " + base.ToString() + " " + Speciality + " " + Group + " " + Rating + " " + Attendace;
		}
	}
}
