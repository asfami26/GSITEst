using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Soal5
    {
        public List<int> ProcessFinalNumbers(List<int> angkaList)
        {
            Console.WriteLine($"Hasil angka dari Soal 4: {string.Join(" ", angkaList)}");
            
            List<int> hasilAkhir = angkaList.Select(angka => 
                    (angka == 0) ? 1 : (angka % 2 == 0) ? angka + 1 : angka).ToList();
            
            Console.WriteLine($"Hasil transformasi angka setelah koreksi: {string.Join(" ", hasilAkhir)}");
            return hasilAkhir;
        }
    }
}