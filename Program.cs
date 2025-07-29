Console.WriteLine("Console Calculator in C#");
Console.WriteLine("____________________________");

Console.WriteLine("Type a number and press Enter!");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Type another number and press Enter again!");
double secondNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");

char choose = char.Parse(Console.ReadLine());
double result;

switch (choose)
{
    case 'a':

        result = firstNumber + secondNumber;

        Console.WriteLine($"Your result: {firstNumber} + {secondNumber} = " + result);

        break;
    case 's':

        result = firstNumber - secondNumber;

        Console.WriteLine($"Your result: {firstNumber} - {secondNumber} = " + result);

        break;
    case 'm':

        result = firstNumber * secondNumber;

        Console.WriteLine($"Your result: {firstNumber} * {secondNumber} = " + result);

        break;
    case 'd':
        while (secondNumber == 0)
            {
                Console.WriteLine("Enter a non-zero divisor: ");
                secondNumber = Convert.ToDouble(Console.ReadLine());
            }

        result = firstNumber / secondNumber;

        Console.WriteLine($"Your result: {firstNumber} / {secondNumber} = " + result);

        break;
}
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
