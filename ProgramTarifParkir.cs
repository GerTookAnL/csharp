using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Program Tarif Parkir Kendaraan");
		Console.WriteLine("=============================================");
		Console.WriteLine();
		mnu:
		Console.WriteLine("Masukkan Jenis Kendaraan:");
		Console.WriteLine();
		Console.WriteLine("1. Mobil");
		Console.WriteLine("2. Motor");
		char K = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("Anda memilih no: "+K);
		Console.WriteLine();
		if (K!='1' && K!='2'){
				Console.WriteLine("Error");
			goto mnu;
		}
		
		Console.WriteLine();
		Console.Write("Masukkan lama parkir (per jam): ");
		int lama = Convert.ToInt32(Console.ReadLine());
		int harga = 2000;
		if (lama > 2) harga=(lama*1000);
		Console.WriteLine(harga);
		
				}
			}
