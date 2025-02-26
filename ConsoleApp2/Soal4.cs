// using System;
// using System.Collections.Generic;
// using System.Linq;
// using ConsoleApp2;
//
// public class Soal4
// {
//     public string ProcessLettersToFinalOutput(string letters)
//     {
//         
//         List<int> angkaList = letters.Select(c => Kamus.HurufKeAngka.ContainsKey(c) ? Kamus.HurufKeAngka[c] : 0).ToList();
//         
//         Console.WriteLine($"Konversi huruf ke angka: {string.Join(" ", angkaList)}");
//         
//         if (angkaList.Count >= 2)
//         {
//             angkaList[angkaList.Count - 1] = 2; 
//             angkaList[angkaList.Count - 2] += 1; 
//         }
//         
//         Console.WriteLine($"Hasil operasi angka: {string.Join(" ", angkaList)}");
//         List<char> hasilHuruf = angkaList.Select(d => Kamus.AngkaKeHuruf.ContainsKey(d) ? Kamus.AngkaKeHuruf[d] : 'E').ToList();
//         return string.Join("", hasilHuruf);
//     }
// }