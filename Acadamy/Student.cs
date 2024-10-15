using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	internal class Student: Human
	{
		static readonly int SPECIALITY_WIDTH = 24;
		static readonly int GROUP_WIDTH = 8;
		static readonly int RATING_WIDTH = 8;
		static readonly int ATTENDACE_WIDTH = 8;
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
			return base.ToString() + " " + Speciality.PadRight(SPECIALITY_WIDTH) + " " + Group.PadRight(GROUP_WIDTH) + " " + Rating.ToString().PadRight(RATING_WIDTH) + " " + Attendace.ToString().PadRight(ATTENDACE_WIDTH);
		}
		public override string ToFileString()
		{
			return base.ToFileString() + "," + Speciality + "," + Group + "," + Rating + "," + Attendace;
		}
		public override Human Init(string[] values)
		{
			base.Init(values);
			Speciality = values[4];
			Group = values[5];
			Rating = Convert.ToInt32(values[6]);
			Attendace = Convert.ToInt32(values[7]);
			return this; 
		}
	}
}
