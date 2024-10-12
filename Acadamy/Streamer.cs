using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	internal class Streamer
	{
		internal static void Write_to_File(Human[] group, string File_Name)
		{
			System.IO.StreamWriter sw = new System.IO.StreamWriter(File_Name);
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
	}
}
