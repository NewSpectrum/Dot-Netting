// See https://aka.ms/new-console-template for more information
using System;

namespace DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
/*		Declaration Examples
Numeric Data Types*/
		/// Integers: Whole numbers
			int a = 75;
		
		
			double b = 7.258;
		
		
			long c = 67893342128382;
		
		// Text-based Data Types
			string ChaCha = "I do the Cha-Cha like a Sissy Girl.";
		
		
			char Nuts = 'n';
		
		// Boolean
		bool Result = true;
		
	/*===|  Output Examples  |===*/
		// Numeric Outputs
		Console.WriteLine("\n'a' = " + a + "\n");
		Console.WriteLine("\n'b' = " + b + "\n");
		Console.WriteLine("\n'c' = " + c + "\n");
		
		// Numeric Outputs v2
		Console.WriteLine("\nNumeric/Integer Data Types:\n");
		Console.WriteLine("\tInteger\tType\tValue\n");
		Console.WriteLine("'a'\t\t");
			Console.Write(c);
			Console.Write("\t");
			
		
		// Simple Arithmetic v2
		Console.Write("\na ⨯ b = ");
			Console.Write(a * b);
		Console.Write("\n\nc ÷ b = ");
			Console.Write(c / b);
		Console.Write("\n\nb + b = ");
			Console.WriteLine(c + b);
		Console.Write("\n\nb - a = ");
			Console.WriteLine(c + b);
			
		// Multi-Step Equations
		Console.Write("\n\nb - a + b = ");
			Console.WriteLine(c - a + b);
		
		
		// Text Output
		Console.WriteLine("\n Text/String Output" + "\n");
		Console.WriteLine("\n'ChaCha' = " + ChaCha + "\n");
		Console.WriteLine("\n'Nuts' = " + Nuts + "\n");
		
		// Boolean Outputs
		Console.WriteLine("\n Test-Patht: " + Result + "\n");
		}
	}
}