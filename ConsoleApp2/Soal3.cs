using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Soal3
    {
        public string ConvertNumberToLetters(int number)
        {
            number = Math.Abs(number); 
            List<char> letterResult = new List<char>(); 
            int sum = 0;

            
            var sortedKamus = Kamus.Data
                .Where(k => k.Key >= 'A' && k.Key <= 'Z') 
                .GroupBy(k => k.Value) 
                .Select(g => g.First()) 
                .OrderBy(k => k.Key) 
                .ToList();

            int index = 0;
            HashSet<char> usedLetters = new HashSet<char>(); 
            bool restarted = false; 

            while (sum < number)
            {
                var current = sortedKamus[index];
                
                if (!usedLetters.Contains(current.Key) && (sum + current.Value <= number))
                {
                    sum += current.Value;
                    letterResult.Add(current.Key);
                    usedLetters.Add(current.Key);
                }

                index++;

               
                if (index >= sortedKamus.Count)
                {
                    if (sum < number) 
                    {
                        index = 0;
                        usedLetters.Clear(); 
                        restarted = true; 
                    }
                    else
                    {
                        break; 
                    }
                }
            }

            return string.Join("", letterResult);
        }
    }
}
