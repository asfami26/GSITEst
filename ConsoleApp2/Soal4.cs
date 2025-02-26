using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Soal4
    {
        public string FormatLetters(string letters)
        {
            List<int> angkaList = letters.Select(c => Kamus.Data.ContainsKey(c) ? Kamus.Data[c] : 0).ToList();
            
            Console.WriteLine($"Konversi huruf ke angka: {string.Join(" ", angkaList)}");
            
            if (angkaList.Count >= 2)
            {
                angkaList[angkaList.Count - 1] = 2; 
                angkaList[angkaList.Count - 2] += 1; 
            }
            
            Console.WriteLine($"Hasil transformasi angka: {string.Join(" ", angkaList)}");
            
            List<char> hasilHuruf = angkaList.Select(d => Kamus.Data.FirstOrDefault(k => k.Value == d).Key).ToList();

            return string.Join("", hasilHuruf);
        }
    }
}