using System;
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
			return "Graduate: " + base.ToString() + " " + Subject;
		}
	}
}
