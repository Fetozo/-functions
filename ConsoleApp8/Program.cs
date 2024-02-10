bool Prost(int num3)
{
    bool pr = true;
    for (int i = 1; i < num3 + 1; i++)
    {
        if ((num3 != i) && (i != 1))
        {
            if (num3 % i == 0)
            {
                pr = false;

            }
        }
    }
    Console.Write("Число простое: ");
    return pr;
}
Console.Write("\nВведите число:");
int num3 = Convert.ToInt32(Console.ReadLine());
bool message3 = Prost(num3);
Console.Write(message3);