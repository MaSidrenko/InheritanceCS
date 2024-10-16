﻿//#define INHERITENCE
//#define GROUP
#define LOAD_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Acadamy
{
	internal class Program
	{
		static string delimiter = "\n|--------------------------------------|\n";
		static void Main(string[] args)
		{
#if INHERITENCE
			Human human = new Human("Montana", "Antonio", 25);
			human.Print();
			Console.WriteLine(human);
			Console.WriteLine(delimiter);
			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			student.Print();
			Console.WriteLine(student);
			Console.WriteLine(delimiter);
			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			//teacher.Print();
			Console.WriteLine(teacher);
			Console.WriteLine(delimiter); 
#endif
#if GROUP
			Human[] group = new Human[]
			{
				new Student("Pinkman", "Jessie", 22, "Chemistry","WW_220" ,95, 96),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Potter", "Harry", 17, "Defence against the Dark Arts", "Gryffindor", 80, 99, "How to defeat Voldemort"),
				new Teacher("Lupin", "Remus", 37, "Defence against the Dark Arts", 5),
				new Student("Skywalker", "Luke", 22, "Jedi", "Jedi Order", 99, 100)
			};
	
		Streamer.Write_to_File(group, "Group.csv");
#endif
#if LOAD_CHECK
			Human[] group = Streamer.Read_form_File("Group.csv");
			Streamer.Print(group);
#endif

		}
	}
}
