// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает последнюю цифру 
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Hello, enter a three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
if(number<0){
    number = number* (-1);
}
if (number >= 100 && number <= 999)
{
int lastDigit = number %10;
Console.WriteLine($"Last digit of three-digit numer: {lastDigit}");
}
else
{
    Console.WriteLine("Wrong number");
}
