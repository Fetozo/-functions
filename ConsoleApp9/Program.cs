String Reverse(string str1)
{
    char[] nstr = str1.ToCharArray();
    Array.Reverse(nstr);
    return new string(nstr);
}
Console.Write("\nВведите строку: ");
string str1 = Console.ReadLine();
string message1 = Reverse(str1);
Console.Write(message1);