using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	internal class Streamer
	{
		internal static string SetDirectory()
		{
			string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
			string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

			Console.WriteLine(location);
			Console.WriteLine(path);
			Directory.SetCurrentDirectory(path + "\\..\\..");
            Console.WriteLine(Directory.GetCurrentDirectory());
			Console.WriteLine("\n|---------------------|\n");
			return Directory.GetCurrentDirectory();
		}
		internal static void Write_to_File(Human[] group, string File_Name)
		{
			SetDirectory();
			System.IO.StreamWriter sw = new System.IO.StreamWriter(File_Name);
			sw.WriteLine("Sep=,");
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine(group[i].ToFileString());
			}
			sw.Close();
			System.Diagnostics.Process.Start("Excel", File_Name);
		}
		internal static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
			Console.WriteLine();
		}
		internal static Human[] Read_form_File(string File_Name)
		{
			SetDirectory();
			List<Human> group = new List<Human>();
			System.IO.StreamReader sr = new System.IO.StreamReader(File_Name);
			try
			{
				string buffer;
				while (!sr.EndOfStream)
				{
					buffer = sr.ReadLine();
					string[] values = buffer.Split(',');
					values = values.Where(s => s != "").ToArray();
					if (values.Length == 1) continue;
					//Console.WriteLine(buffer);
					//Human human = HumanFactory.Create(values[0]);
					//human.Init(values);
					//group.Add(human);
					group.Add(HumanFactory.Create(values[0]).Init(values));
				}
				sr.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return group.ToArray();
		}
	}
}
