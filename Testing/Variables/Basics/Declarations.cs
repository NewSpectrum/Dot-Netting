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
		long c = 67893342128382;
		
		// Text-based Data Types
		string ChaCha = "I do the Cha-Cha like a Sissy Girl.";
		char Nuts = 'n';
		
		// Boolean
		bool Result = true;
		
	/*===|  Output Examples  |===*/
		// Numeric Outputs
		Console.WriteLine("\n Text/String Output" + "\n");
		Console.WriteLine("\n'a' = " + a + "\n");
		Console.WriteLine("\n'b' = " + b + "\n");
		Console.WriteLine("\n'c' = " + c + "\n");
		
		// Simple Arithmetic
		Console.WriteLine("\na ⨯ b = ", a * b, "\n");
		Console.WriteLine("\nc ÷ b = ", c / b, "\n");
		Console.WriteLine("\nb + b = ", c + b, "\n");
		Console.WriteLine("\nb - a + b = ", c - a + b, "\n");
		
		// Simple Arithmetic v2
		Console.Write("\na ⨯ b = ");
			Console.WriteLine(a * <b>, "\n");
		Console.Write("\nc ÷ b = ");
			Console.WriteLine("\nc ÷ b = ", c / b, "\n");
		Console.Write("\nb + b = ");
			Console.WriteLine("\nb + b = ", c + b, "\n");
		Console.Write("\nb - a = ");
			Console.WriteLine("\nb + b = ", c + b, "\n");
			
		
		Console.Write("\nb - a + b = ");
			Console.WriteLine("\nb - a + b = ", c - a + b, "\n");
		
		
		// Text Output
		Console.WriteLine("\n Text/String Output" + "\n");
		Console.WriteLine("\n'ChaCha' = " + ChaCha + "\n");
		Console.WriteLine("\n'Nuts' = " + Nuts + "\n");
		
		// Boolean Outputs
		Console.WriteLine("\n Test-Patht: " + Result + "\n");
		}
	}
}