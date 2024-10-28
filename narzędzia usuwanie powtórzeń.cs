
using System.ComponentModel;

internal class Program
{

    public static void Main(string[] args)
    {
        char[] samogloski = { 'a', 'ą', 'e', 'ę', 'i', 'o', 'u', 'ó', 'y', 'A', 'Ą', 'E', 'Ę', 'I', 'O', 'U', 'Ó', 'Y' };
        Console.WriteLine("Wpisz zdanie");
        string zdanie = Console.ReadLine();
        int iloscSamoglosek = liczenieSamogłosek(zdanie);
        Console.WriteLine("Ilość samogłosek:");
        Console.WriteLine(iloscSamoglosek);
        string usunietePowtorzenia = usuwaniePowtorzen(zdanie);
        Console.WriteLine(usunietePowtorzenia);
    }

    public static string usuwaniePowtorzen(string zdanie)
    {
        string template = "";
        bool[] boole = new bool[zdanie.Length];
        for (int i = 0; i < zdanie.Length - 1; i++)
        {
            char literki = zdanie[i];
            if (zdanie[i] == zdanie[i + 1])
            {
                boole[i] = true;
            }
            
        }
        for (int i = 0; i < zdanie.Length; i++)
        {
            if (boole[i] == false)
            {
                Console.Write(zdanie[i]);
            }
        }
    
        
        return template;
        
        
    }

    public static int liczenieSamogłosek(string literki)
    {
        int licznik = 0;
        char[] samogloski = { 'a', 'ą', 'e', 'ę', 'i', 'o', 'u', 'ó', 'y', 'A', 'Ą', 'E', 'Ę', 'I', 'O', 'U', 'Ó', 'Y' };
        for (int i = 0; i < literki.Length; i++) 
        {
            char litery = literki[i];
            for (int j = 0; j < samogloski.Length; j++) 
            {
                if (litery == samogloski[j]) 
                {
                    licznik++;
                }
            }
        }
        return licznik;
    }
}