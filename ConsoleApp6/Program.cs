string palindrome(string str)
{
    int i = 0;
    int j = str.Length - 1;
    bool pal = true;
    for (i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            str.Remove(i);
        }
    }
    while ((i < str.Length - 1) && (j > 0))
    {
        i++;
        j--;
        if (str[i] != str[j])
        {
            pal = false;
            break;
        }
    }
    if (pal == true)
    {
        return "строка является палиндромом ";
    }
    else
    {
        return "строка не является палиндромом ";
    }
}
Console.Write("\nВведите строку: ");
string str = Console.ReadLine();
string message2 = palindrome(str);
Console.Write(message2);

