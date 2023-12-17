// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Hello, enter number from 1 to 7");
string number = Console.ReadLine();
switch(number){
    case "1": Console.WriteLine("Monday");
    break;
    case "2":Console.WriteLine("Tuesday");
    break;
    case "3":Console.WriteLine("Wednesday");
    break;
    case  "4":Console.WriteLine("Thursday");
    break;
    case  "5":Console.WriteLine("Friday");
    break;
    case  "6":Console.WriteLine("Satarday");
    break;
    case  "7":Console.WriteLine("Sunday");
    break;
    default:Console.WriteLine("Wrong number.");
    break;
}

// if (number == 1){
//     Console.WriteLine("Monday");
// } else if (number == 2){
//     Console.WriteLine("Tuesday");
// }
// else if (number == 3){
//     Console.WriteLine("Wednesday");
// }
// else if (number == 4){
//     Console.WriteLine("Thursday");
// }
// else if (number == 5){
//     Console.WriteLine("Friday");
// }
// else if (number == 6){
//     Console.WriteLine("Saturday");
// }
// if (number == 7){
//     Console.WriteLine("Sunday");
// }
// else {
//     Console.WriteLine("Wrong number.");
// }
