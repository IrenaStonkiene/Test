// See https://aka.ms/new-console-template for more information
double Number1 = 1;
double Number2 = 2;
char Action = '+';

Console.WriteLine("Enter the 1st number:");
string numb1String = Console.ReadLine();
bool numb1Parsed = double.TryParse(numb1String, out Number1);

Console.WriteLine("Enter the 2nd number:");
string numb2String = Console.ReadLine();
bool numb2Parsed = double.TryParse(numb2String, out Number2);

Console.WriteLine("Enter the action what you want to do:");
string actionString = Console.ReadLine();
bool actionParsed = char.TryParse(actionString, out Action);

switch (Action)
{
    case '+':
        Console.WriteLine($"{Number1} + {Number2} = {Number1 + Number2}");
        break;
    case '_':
        Console.WriteLine($"{Number1} - {Number2} = {Number1 - Number2}");
        break;
    case '/':
        if (Number2 == 0)
            Console.WriteLine("Dividing by 0 is not possible");
        else
            Console.WriteLine($"{Number1} / {Number2} = {Number1 / Number2}");
        break;
    case '*':
        Console.WriteLine($"{Number1} * {Number2} = {Number1 * Number2}");
        break;
    case '%':
        Console.WriteLine($"{Number1} % {Number2} = {Number1 % Number2}");
        break;
    case 'p':
        Console.WriteLine($"The elements are: {Number1} and {Number2}");
        break;
    case 'b':
        if (Number1 > Number2)
        Console.WriteLine($"The element {Number1} is bigger");
        if (Number2 > Number1)
            Console.WriteLine($"The element {Number2} is bigger");
        break;
    case 's':
        if (Number1 < Number2)
            Console.WriteLine($"The element {Number1} is smaller");
        if (Number2 < Number1)
            Console.WriteLine($"The element {Number2} is smaller");
        break;

}
