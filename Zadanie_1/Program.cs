int n= Prompt("Введите пятизначное число: ");
if (n>=10000 && n<=99999)
{
    Palindrom(n);
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число!");
}



int Prompt(string message)
{
    Console.Write(message);
    int value=int.Parse(Console.ReadLine());
    int numN=Convert.ToInt32(value);
    return numN;
}

void Palindrom(int number)
{
    int numberOne=number/10000;
    int numberFive=number%10;
    if (numberOne==numberFive)
    {
        int numberTwo=(number/1000)%10;
        int numberFour=(number%100)/10;
        if(numberTwo==numberFour)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
    else
    {
        Console.WriteLine("Нет");
    }
}