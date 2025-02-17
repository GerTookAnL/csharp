using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Program Kasir Rumah Makan");
		Console.WriteLine("=============================================");
		Console.WriteLine();
		mnu:
		Console.Write("Menu makanan         Harga");
		Console.WriteLine("\n1. Ayam Goreng       Rp10.000");
		Console.WriteLine("\n2. Nasi Goreng       Rp8.000");
		Console.WriteLine("\n3. Mie Pangsit       Rp10.000");
		Console.WriteLine("\n4. Nasi Balap Puyung Rp12.000");
		Console.WriteLine("\n5. Nasi Campur       Rp8.000");
		Console.WriteLine("\n6. Jus Jeruk         Rp6.000");
		Console.WriteLine("\n7. Air Gelas         Rp500");
		Console.WriteLine("\nMasukkan Pilihan Anda");
		char menu = Convert.ToChar(Console.ReadLine());
		
		if (menu != '1' && menu!='2' && menu!='3' && menu!='4' && menu!='5' && menu!='6' && menu!='7'){
			Console.Write("Error");
			goto mnu;
		}
		
		if (menu == '1'){
			Console.WriteLine("Ayam Goreng");
			Console.WriteLine("\nMasukkan Jumlah");
			int Jml = Convert.ToInt32(Console.ReadLine());
			int Harga = 10000;
			if (Jml >= 2) Harga=(Jml*10000);
			Console.WriteLine("Total harga: Rp" +Harga);
			byr:
			Console.WriteLine("\nJumlah bayar: ");
			int byr = Convert.ToInt32(Console.ReadLine());
			int kembalian = byr - Harga;
		
			Console.WriteLine("Dibayar: Rp"+byr);
			Console.WriteLine("Kembali: Rp"+kembalian);
			if (byr < Harga){
				Console.WriteLine("\nKurang");
			goto byr;}
			
		}
		else if (menu == '2'){
			Console.WriteLine("Nasi Goreng");
			Console.WriteLine("\nMasukkan Jumlah");
			int Jml = Convert.ToInt32(Console.ReadLine());
			int Harga = 8000;
			if (Jml >= 2) Harga=(Jml*8000);
			Console.WriteLine("Total harga: Rp" +Harga);
			byr:
			Console.WriteLine("\nJumlah bayar: ");
			int byr = Convert.ToInt32(Console.ReadLine());
			int kembalian = byr - Harga;
		
			Console.WriteLine("Dibayar: Rp"+byr);
			Console.WriteLine("Kembali: Rp"+kembalian);
			if (byr < Harga){
				Console.WriteLine("\nKurang");
			goto byr;}
			
			}
		else if (menu == '3'){
			Console.WriteLine("Mie Pangsit");
			Console.WriteLine("\nMasukkan Jumlah");
			int Jml = Convert.ToInt32(Console.ReadLine());
			int Harga = 10000;
			if (Jml >= 2) Harga=(Jml*10000);
			Console.WriteLine("Total harga: Rp" +Harga);
			byr:
			Console.WriteLine("\nJumlah bayar: ");
			int byr = Convert.ToInt32(Console.ReadLine());
			int kembalian = byr - Harga;
		
			Console.WriteLine("Dibayar: Rp"+byr);
			Console.WriteLine("Kembali: Rp"+kembalian);
			if (byr < Harga){
				Console.WriteLine("\nKurang");
			goto byr;}
			
			}
		else if (menu == '4'){
			Console.WriteLine("Nasi Balap Puyung");
			Console.WriteLine("\nMasukkan Jumlah");
			int Jml = Convert.ToInt32(Console.ReadLine());
			int Harga = 12000;
			if (Jml >= 2) Harga=(Jml*12000);
			Console.WriteLine("Total harga: Rp" +Harga);
			byr:
			Console.WriteLine("\nJumlah bayar: ");
			int byr = Convert.ToInt32(Console.ReadLine());
			int kembalian = byr - Harga;
		
			Console.WriteLine("Dibayar: Rp"+byr);
			Console.WriteLine("Kembali: Rp"+kembalian);
			if (byr < Harga){
				Console.WriteLine("\nKurang");
			goto byr;}
			
			}
		else if (menu == '5'){
			Console.WriteLine("Nasi Campur");
			Console.WriteLine("\nMasukkan Jumlah");
			int Jml = Convert.ToInt32(Console.ReadLine());
			int Harga = 8000;
			if (Jml >= 2) Harga=(Jml*8000);
			Console.WriteLine("Total harga: Rp" +Harga);
			byr:
			Console.WriteLine("\nJumlah bayar: ");
			int byr = Convert.ToInt32(Console.ReadLine());
			int kembalian = byr - Harga;
		
			Console.WriteLine("Dibayar: Rp"+byr);
			Console.WriteLine("Kembali: Rp"+kembalian);
			if (byr < Harga){
				Console.WriteLine("\nKurang");
			goto byr;}
			
			}
		else if (menu == '6'){
			Console.WriteLine("Jus Jeruk");
			Console.WriteLine("\nMasukkan Jumlah");
			int Jml = Convert.ToInt32(Console.ReadLine());
			int Harga = 6000;
			if (Jml >= 2) Harga=(Jml*6000);
			Console.WriteLine("Total harga: Rp" +Harga);
			byr:
			Console.WriteLine("\nJumlah bayar: ");
			int byr = Convert.ToInt32(Console.ReadLine());
			int kembalian = byr - Harga;
		
			Console.WriteLine("Dibayar: Rp"+byr);
			Console.WriteLine("Kembali: Rp"+kembalian);
			if (byr < Harga){
				Console.WriteLine("\nKurang");
			goto byr;}
			
			}
		else if (menu == '7'){
			Console.WriteLine("Air Gelas");
			Console.WriteLine("\nMasukkan Jumlah");
			int Jml = Convert.ToInt32(Console.ReadLine());
			int Harga = 500;
			if (Jml >= 2) Harga=(Jml*500);
			Console.WriteLine("Total harga: Rp" +Harga);
			byr:
			Console.WriteLine("\nJumlah bayar: ");
			int byr = Convert.ToInt32(Console.ReadLine());
			int kembalian = byr - Harga;
		
			Console.WriteLine("Dibayar: Rp"+byr);
			Console.WriteLine("Kembali: Rp"+kembalian);
			if (byr < Harga){
				Console.WriteLine("\nKurang");
			goto byr;}
			
		}
			
			Console.WriteLine("Masih ada? Y/T");
			char YT = Convert.ToChar(Console.ReadLine());
			
			if(YT == 'Y'){
				goto mnu;}
			if(YT == 'T'){
				Console.WriteLine("Terima kasih atas kunjungan anda");
		}
	}
}

