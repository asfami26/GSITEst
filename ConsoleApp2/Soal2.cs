namespace ConsoleApp2;

public class Soal2
{
    public int ProcessNumbers(string numberString)
    {
        int[] numbers = numberString.Split(' ').Select(int.Parse).ToArray();
        int result = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (i % 2 == 1)
                result += numbers[i];
            else
                result -= numbers[i];
        }

        return result;
    }
}