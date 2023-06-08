// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел 
//от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

string KubInline (double N)
{
    int count = 1;
    int kub;
    string result = "";

    while (count <= N)
    {
        kub = count*count*count;
        result = result + " " + kub.ToString();
        count++;
    }
    return result;
}

Console.Clear();
System.Console.WriteLine("А введите какое-нибудь целое положительное число");
double N = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(KubInline(N));
