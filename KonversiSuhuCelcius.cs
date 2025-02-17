using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Masukkan suhu dalam Celcius");
		int C = Convert.ToInt32(Console.ReadLine());
		int K = C + 273;
		int F = C*9/5 + 32;
		int R = C*4/5;
		Console.WriteLine("Derajat dalam Kelvin adalah " + K);
		Console.WriteLine("Derajat dalam Fahrenheit adalah " + F);
		Console.WriteLine("Derajat dalam Reamur adalah " + R);
	}
}
