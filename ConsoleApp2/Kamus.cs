namespace ConsoleApp2;

public class Kamus
{
    public static readonly Dictionary<char, int> HurufKeAngka = new Dictionary<char, int>
    {
        {'A', 0}, {'B', 1}, {'C', 1}, {'D', 1}, {'E', 2}, {'F', 3}, {'G', 3}, {'H', 3},
        {'I', 4}, {'J', 5}, {'K', 5}, {'L', 5}, {'M', 5}, {'N', 5}, {'O', 6}, {'P', 7},
        {'Q', 7}, {'R', 7}, {'S', 7}, {'T', 7}, {'U', 8}, {'V', 9}, {'W', 9}, {'X', 9},
        {'Y', 9}, {'Z', 9}, {'a', 9}, {'b', 8}, {'c', 8}, {'d', 8}, {'e', 7}, {'f', 6},
        {'g', 6}, {'h', 6}, {'i', 5}, {'j', 4}, {'k', 4}, {'l', 4}, {'m', 4}, {'n', 4},
        {'o', 3}, {'p', 2}, {'q', 2}, {'r', 2}, {'s', 2}, {'t', 2}, {'u', 1}, {'v', 0},
        {'w', 0}, {'x', 0}, {'y', 0}, {'z', 0}, {' ', 0}
    };

    // Kamus angka ke huruf (Soal 3)
    public static readonly Dictionary<int, char> AngkaKeHuruf = new Dictionary<int, char>
    {
        {0, 'A'}, {1, 'B'}, {2, 'E'}, {3, 'F'}, {4, 'I'}, {5, 'J'},
        {6, 'N'}, {7, 'O'}, {8, 'U'}, {9, 'V'}
    };
}