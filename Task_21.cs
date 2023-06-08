// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double Length(double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    double result = Math.Sqrt((Bx-Ax)*(Bx-Ax) + (By-Ay)*(By-Ay)+(Bz-Az)*(Bz-Az));
    return Math.Round(result,2);
}

System.Console.WriteLine("Введите первую координату точки А");
double Ax = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату А");
double Ay = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите третью координату А");
double Az = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую координату точки В");
double Bx = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату точки В");
double By = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите третью координату точки В");
double Bz = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"расстояние между точками составит {Length(Ax, Ay, Az, Bx, By, Bz)}");
 
