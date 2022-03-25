string wpisz, wypisz;
char[] alfabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
Console.WriteLine("Podaj tekst, ktory chcesz zaszyfrowac.");
wpisz = Convert.ToString(Console.ReadLine());
char[] zdanie = wpisz.ToCharArray();
Console.WriteLine("Podaj wartosc przesuniecia.");
int przesuniecie; 
    Int32.TryParse(Console.ReadLine(), out przesuniecie);
char[] zaszyfrowane = new char[zdanie.Length];


for (int i = 0; i < zdanie.Length; i++)
{
    char litera = zdanie[i];
    if (zdanie[i] == ' ' || zdanie[i] == '\n') continue;
    int pozycja = Array.IndexOf(alfabet, litera);
    int nowaPozycja = (pozycja + przesuniecie) % 26;
    char literaZaszyfrowana = alfabet[nowaPozycja];
    zaszyfrowane[i] = literaZaszyfrowana;
}

wypisz = string.Join("", zaszyfrowane);
Console.WriteLine(wypisz);