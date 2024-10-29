
using System.ComponentModel;

internal class Program
{

    public static void Main(string[] args)
    {
        char[] samogloski = { 'a', 'ą', 'e', 'ę', 'i', 'o', 'u', 'ó', 'y', 'A', 'Ą', 'E', 'Ę', 'I', 'O', 'U', 'Ó', 'Y' };
        Console.WriteLine("Wpisz zdanie");
        string zdanie = Console.ReadLine();
        string usunietePowtorzenia = usuwaniePowtorzen(zdanie);
        Console.WriteLine("Skrócone zdanie:");
        Console.WriteLine(usunietePowtorzenia);
        int iloscSamoglosek = liczenieSamogłosek(usunietePowtorzenia);
        Console.WriteLine("Ilość samogłosek:");
        Console.WriteLine(iloscSamoglosek);
    }

    public static string usuwaniePowtorzen(string zdanie)
    {
        string skroconeZdanie = "";
        if (string.IsNullOrEmpty(zdanie))
        {
            return "";
        }
        bool[] boole = new bool[zdanie.Length];
        for (int i = 0; i < zdanie.Length - 1; i++)
        {

            if (zdanie[i] == zdanie[i + 1])
            {
                boole[i] = true;
            }

        }
        for (int i = 0; i < zdanie.Length; i++)
        {
            if (boole[i] == false)
            {
                skroconeZdanie += Convert.ToString(zdanie[i]);
            }

        }
        return skroconeZdanie;







    }

    public static int liczenieSamogłosek(string literki)
    {
        if (string.IsNullOrEmpty(literki))
        {
            return 0;
        }
        int licznik = 0;
        char[] samogloski = { 'a', 'ą', 'e', 'ę', 'i', 'o', 'u', 'ó', 'y', 'A', 'Ą', 'E', 'Ę', 'I', 'O', 'U', 'Ó', 'Y' };
        for (int i = 0; i < literki.Length; i++)
        {

            for (int j = 0; j < samogloski.Length; j++)
            {
                if (literki[i] == samogloski[j])
                {
                    licznik++;
                }
            }
        }
        return licznik;
    }
}
