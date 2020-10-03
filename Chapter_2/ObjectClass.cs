using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{

	class Temp
	{
		string temp;
		public Temp(string temp)
		{
			this.temp = temp;
		}

		///summary Multiple Main methods are managed by Project properties-> Application -> StartUp Object Select the StartUpObject which has main out of the list
		//static void Main()
		//{
		//	Console.WriteLine("Hello");
		//}
	}


	public static class StringExtension
	{
		public static void TestingExtension(this String str)
		{
			Console.WriteLine(str+" Extension Added");
		}
	}


	class ObjectClass
	{
		public static void Main(string[] args)
		{
			#region MainMethod
			Temp t1 = new Temp("temp");
			Console.WriteLine("Calling ToString(): " + t1.ToString());
			Console.WriteLine("Calling GetType(): " + t1.GetType());
			Console.WriteLine("Calling GetHashCode(): " + t1.GetHashCode());
			Temp t2 = t1;
			Console.WriteLine("Calling Equals(): " + t1.Equals(t2));    // checks if references point to same location or not
			t2 = new Temp("temp");
			Console.WriteLine("Calling Equals(): " + t1.Equals(t2));

			//Formatting Console Output
			new ObjectClass().ConsoleExample();

			//Using extension method
			string str = "Hello world, string";
			str.TestingExtension();

			#endregion
		}
		/// <summary>
		/// This is used for generating documentation in XML format from this Special Comments
		/// </summary>
		void ConsoleExample()
		{
			#region Console I/O
			Console.WriteLine("\n{0,-10}\n{1,10}\n\n\n\n", 90, 10); //Negative is left aligned and positive means right aligned

			Console.WriteLine("{0,10}\n+{1,9}\n----------\n{2,10}\n----------\n\n\n", 940, 73, (940 + 73)); // 9 coz 1 space us used by +

			//Change font of Console to Consolas or something else which supports Rupee symbol and set OutputEncoding as follows:
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("{0,10:C2}\n+{1,9:C2}\n----------\n{2,10:C2}\n----------\n\n\n", 940.20, 73.50, (940.20 + 73.50));    // number after C means no. of digits after digit

			Console.WriteLine("{0,5:#.00}", 0.234); // Outputs .23
			Console.WriteLine("{0,5:#.00}", 1.234); // Outputs 1.23, # is ignored by digit if there is any and also 0's are replaced by digits
			Console.WriteLine("{0,5:#.00}", 2.5);   // Oututs 2.50 as if no digit 0 will retain that position
			Console.WriteLine("{0,5:#.000}", 0.7);  //Outputs .700
			#endregion
		}
	}
}
