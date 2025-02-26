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
            List<int> hasilAkhir = new List<int>();

           
            for (int i = 0; i < angkaList.Count; i++)
            {
                int angka = angkaList[i];

                if (angka == 0) 
                {
                    hasilAkhir.Add(1);
                }
                else if (angka % 2 == 0) 
                {
                    hasilAkhir.Add(angka + 1);
                }
                else 
                {
                    hasilAkhir.Add(angka);
                }
            }
            
            Console.WriteLine($"Hasil transformasi angka setelah koreksi: {string.Join(" ", hasilAkhir)}");

            return hasilAkhir;
        }
    }
}