// See https://aka.ms/new-console-template for more information
using System;

namespace DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
	/*===|  Declaration Examples  |===*/
		// Numeric Data Types
		int a = 75;
		double b = 7.258;
		long c = 67,893,342,128,382;
		
		// Text-based Data Types
		string ChaCha = "I do the Cha-Cha like a Sissy Girl.";
		char Nuts = 'n';
		
		// Boolean
		bool Result = true;
		
	/*===|  Output Examples  |===*/
		// Numeric Outputs
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		
		Console.WriteLine(a * b);
		Console.WriteLine(a / b);
		
		// Text Outputs
		Console.WriteLine(ChaCha);
		Console.WriteLine(Nuts);
		
		// Text Outputs
		Console.WriteLine("Result: " + Result);
		}
	}
}