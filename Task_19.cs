// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом. Через строку решать нельзя.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
int num=Convert.ToInt32(Console.ReadLine());
int numOne=num/10000;
int numTwo=(num%10000)/1000;
int numThre=(num%1000)/100;
int numFour=(num%100)/10;
int numFive=num%10;
//System.Console.WriteLine($"{numOne},{numTwo},{numThre},{numFour},{numFive}");
if(numOne==numFive && numTwo==numFour)
{
System.Console.WriteLine("Число является палиндромом");
}
else
System.Console.WriteLine("Число не является палиндромом");