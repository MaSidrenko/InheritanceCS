﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	internal class Human
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }
		//		Constructors:
		public Human(string lastName, string firstName, int age)
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
            //Console.WriteLine("HConstructor: " + GetHashCode());
		}
		~Human() 
		{
            //Console.WriteLine("HDestructor: " + GetHashCode());
		}
		public virtual void Print()
		{
            Console.WriteLine(LastName + " " + FirstName + " " + Age);
		}
		public override string ToString()
		{
			return LastName + " " + FirstName + " " + Age;
		}

	}
}
