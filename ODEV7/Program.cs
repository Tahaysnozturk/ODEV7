using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir ikili sayı girin: ");
        string ikiliSayi = Console.ReadLine();

        int ondalikDeger = 0;
        int tabanDeger = 1;

        for (int i = ikiliSayi.Length - 1; i >= 0; i--)
        {
            if (ikiliSayi[i] == '1')
            {
                ondalikDeger += tabanDeger;
            }
            tabanDeger *= 2;
        }

        Console.WriteLine("Girilen ikili (Binary) Sayı: " + ikiliSayi);
        Console.WriteLine("Ondalık (Decimal) Sayı: " + ondalikDeger);
    }
}
