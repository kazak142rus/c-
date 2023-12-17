//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Hi, enter first number?");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter second number?");
int b = Convert.ToInt32(Console.ReadLine());
int maximal, minimal;
if (a>b) {
    maximal = a;
    minimal = b;
    Console.WriteLine($"Of the entered numbers, the Maximum is {maximal}, the minimal is {minimal}");
} if (a<b){
    maximal = b;
    minimal = a;
    Console.WriteLine($"Of the entered numbers, the Maximum is {maximal}, the minimal is {minimal}");

} else {
    Console.WriteLine("Entered numbers equal");

}
