// Считать с консоли стороку, состоящую из цифр
// и латинских букв
// Сформировать новую строку, состоящую из 
// букв исходной стороки

string GetLetters (string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLetters(str);
System.Console.WriteLine(str);