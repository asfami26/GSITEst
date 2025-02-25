namespace ConsoleApp2;

public class Soal1
{
    
    public string ConvertTextToNumbers(string input)
    {
        return string.Join(" ", input.Select(c => Kamus.HurufKeAngka.ContainsKey(c) ? Kamus.HurufKeAngka[c].ToString() : ""));
    }
}