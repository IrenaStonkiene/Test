// See https://aka.ms/new-console-template for more information
/*
for (int i = 85; i < 95; i++)
{
    Console.WriteLine($"i");
}
// write a loop which 

for (int i = 8; i <= 15; i++)
{ Console.WriteLine($"It is {i} o'clock");}
*/

/*
int [] intArray = new int [5];
intArray [0] = 1;
intArray [1] = 2;   
intArray [2] = 3;   
intArray [3] = 4;
intArray [4] = 5;
var rand = new Random ();
var randLimit = rand.Next(0,5);
var lengthofArray = intArray.Length;
var sumofArray = intArray [0] + intArray [1] + intArray [2] + intArray [3] + intArray [4];

Console.WriteLine($"The value of the first array is: {intArray[0]}");
Console.WriteLine($"The value of the last array is: {intArray[4]}");
Console.WriteLine($"The value of the third array is: {intArray[2]}");
Console.WriteLine($"The value of the random array is: {randLimit}");
Console.WriteLine($"The length of array is: {lengthofArray}");
Console.WriteLine($"The sum of the all elements in array is: {sumofArray}");
Console.WriteLine($"The values of the array are: {intArray[0]}, {intArray[1]}, {intArray[2]}, {intArray[3]}, { intArray[4]} ");
*/

Console.WriteLine("*********************************");

int [] intArray2 = new int [5];
Random randomNumber = new Random();
int sum = 0;

for (int i = 0; i < intArray2.Length - 1; i++)
{ 
    intArray2[i] = randomNumber.Next(0, 5); 
}

Console.WriteLine("Please, enter the first element in array");
string firstNumberString = Console.ReadLine();
bool firstNumberParse = int.TryParse(firstNumberString, out intArray2[0]);

Console.WriteLine("Please, enter the last element in array");
string lastNumberString = Console.ReadLine();
bool lastNumberPParse = int.TryParse(lastNumberString, out intArray2[intArray2.Length - 1]);

Console.WriteLine($"The first number in array is {intArray2[0]}");
Console.WriteLine($"The last number in array is {intArray2[intArray2.Length - 1]}");

for (int i = 0; i < intArray2.Length; i++)
{
    Console.WriteLine($"{ i + 1}. number of array is {intArray2[i]}");
    sum += intArray2[i];
}
Console.WriteLine($"The sum of array elements is {sum}");
Console.WriteLine($"The sum of user input elements is {intArray2[0]} + {intArray2[intArray2.Length - 1]}");