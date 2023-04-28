int xa= Prompt("Введите координату Xa: ");
int ya= Prompt("Введите координату Ya: ");
int za= Prompt("Введите координату Za: ");
int xb= Prompt("Введите координату Xb: ");
int yb= Prompt("Введите координату Yb: ");
int zb= Prompt("Введите координату Zb: ");

int Prompt(string message)
{
    Console.Write(message);
    int value=int.Parse(Console.ReadLine());
    int numN=Convert.ToInt32(value);
    return numN;
}
double distance=FindDistance(xa, xb, ya, yb, za, zb);
Console.WriteLine(distance);
double FindDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result=Convert.ToDouble(Math.Round(Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))+((z2-z1)*(z2-z1))), 2));
    return result;
}