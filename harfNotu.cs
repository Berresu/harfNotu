using System;
class HelloWorld {
	static void Main() {
		Console.Write("Vize Notunuzu Giriniz: ");
		double vize = double.Parse(Console.ReadLine());

		Console.Write("Final Notunuzu Giriniz: ");
		double final = double.Parse(Console.ReadLine());

		double ortalama = vize * 0.4 + final * 0.6;

		if (ortalama >= 90)
		{
			Console.WriteLine("Harf Notunuz: AA");
		}
		else if (ortalama >= 85)
		{
			Console.WriteLine("Harf Notunuz: BA");
		}
		else if (ortalama >= 80)
		{
			Console.WriteLine("Harf Notunuz: BB");
		}
		else if (ortalama >= 75)
		{
			Console.WriteLine("Harf Notunuz: CB");
		}
		else if (ortalama >= 70)
		{
			Console.WriteLine("Harf Notunuz: CC");
		}
		else if (ortalama >= 65)
		{
			Console.WriteLine("Harf Notunuz: DC");
		}
		else if (ortalama >= 60)
		{
			Console.WriteLine("Harf Notunuz: DD");
		}
		else if (ortalama >= 50)
		{
			Console.WriteLine("Harf Notunuz: FD");
		}
		else
		{
			Console.WriteLine("Harf Notunuz: FF");
		}
	}
}
