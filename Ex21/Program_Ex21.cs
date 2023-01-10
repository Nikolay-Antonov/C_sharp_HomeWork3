// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
///A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double GetDistanse(double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) +
     Math.Pow(y2 - y1, 2) +
     Math.Pow(z2 - z1, 2));
}

double GetValue(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = GetValue("x1 =  ");
double y1 = GetValue("y1 =  ");
double z1 = GetValue("z1 =  ");
double x2 = GetValue("x2 =  ");
double y2 = GetValue("y2 =  ");
double z2 = GetValue("z2 =  ");

double distanse = GetDistanse(x1, y1, x2, y2, z1, z2);
System.Console.WriteLine(distanse);
