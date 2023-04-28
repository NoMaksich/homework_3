int n= Prompt("Введите число больше 1: ");
if (n>=1)
{
    Table(n);
}
else
{
    Console.WriteLine("Число меньше 1!");
}



int Prompt(string message)
{
    Console.Write(message);
    int value=int.Parse(Console.ReadLine());
    int numN=Convert.ToInt32(value);
    return numN;
}

void Table(int number)
{
    int startNumber=1;
    while (startNumber<=number)
    {
        Console.Write(startNumber*startNumber*startNumber+ " ");
        startNumber++;
    }
}