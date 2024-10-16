﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	internal class Graduate :Student 
	{
		string Subject;
		public Graduate(string lastName, string firstName, int age, 
			string specoality, string group, double rating, double attendace,
			string subject) : base(lastName, firstName, age, specoality, group, rating, attendace)
		{
			Subject = subject;
            //Console.WriteLine("GConstructor:" + GetHashCode());
		}
		~Graduate()
		{
            //Console.WriteLine("GDestructor:" + GetHashCode());
		}
		public void Print()
		{
			base.Print();
            Console.WriteLine(Subject);
		}
		public override string ToString()
		{
			return base.ToString().PadRight(16) + " " + Subject;
		}
		public override string ToFileString()
		{
			return base.ToFileString() + "," + Subject;
		}
		public override Human Init(string[] values)
		{
			base.Init(values);
			Subject = values[8];
			return this; 
		}
	}
}
