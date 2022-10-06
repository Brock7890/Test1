Start:
Console.Write("enter num between 1 and 7 (inclusive): ");
try
{
    int x = Convert.ToInt32(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("1-7 please");
            break;
    }
}
catch
{
    Console.WriteLine("incorrect input");
}
goto Start;