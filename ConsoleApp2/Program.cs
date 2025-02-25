using System;
using ConsoleApp2;

class Program
{
    static void Main()
    {
        Soal1 Soal1 = new Soal1();
        Soal2 Soal2 = new Soal2();
    
        Console.Write("Masukkan teks: ");
        string input = Console.ReadLine();

        // Soal 1: Konversi teks ke angka
        string numberString = Soal1.ConvertTextToNumbers(input);
        Console.WriteLine("Konversi ke angka: " + numberString);

        // Soal 2: Jumlah & kurang bergantian
        int result = Soal2.ProcessNumbers(numberString);
        Console.WriteLine("Hasil operasi jumlah-kurang: " + result);
    }
}