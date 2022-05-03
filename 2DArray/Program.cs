using SuperHero;

// See https://aka.ms/new-console-template for more information

/* Practical part 1:
Create array with 5 elements, type int, initialize values.
Print first, last and any other element from array.

Change program - initialization of values should use random numbers.
Print all five elements and length of array.

Calculate and output sum of all elements in array.
<bonus>
add user input. Program should ask user to set first and last element in array. Others elements should have random values.
 Output all elements and calculate sum of all elements and sum of elements that were set by user input.

Practical part 2 (individual, up to 20 min):
Using teachers code as example create two dimensional array 3x5 and initiate values.
Output these in proper way.
<bonus>
change type to float, add functionality that calculates sum-s in rows and in columns
*/


int[,] my2DArray = {{1,2,3,4,5}, {6,7,8,9,10}, { 7,8,9,10,11}};
Console.WriteLine($"{my2DArray[0, 0]} , {my2DArray[0, 1]} , {my2DArray[0, 2]}, {my2DArray[0, 3]} , {my2DArray[0, 4]}");
Console.WriteLine($"{my2DArray[1, 0]} , {my2DArray[1, 1]} , {my2DArray[1, 2]}, {my2DArray[1, 3]} , {my2DArray[1, 4]}");
Console.WriteLine($"{my2DArray[2, 0]} , {my2DArray[2, 1]} , {my2DArray[2, 2]}, {my2DArray[2, 3]} , {my2DArray[2, 4]}");

// change type to float, add functionality that calculates sum-s in rows and in columns

Console.WriteLine("-------Bonus tasks-----------");

float[,] my2DArray1 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 7, 8, 9, 10, 11 } };

var rowCount = my2DArray1.GetLength(0);
var columnCount = my2DArray1.GetLength(1);

var rowSums = new float[rowCount];
var colSums = new float[columnCount];

for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < columnCount; j++)
    {
        rowSums[i] += my2DArray1[i, j];
        colSums[j] += my2DArray1[i, j];
    }
    Console.WriteLine($" The sum of {i} row: {rowSums[i]}");
}

for (int j = 0; j < columnCount; j++)
{
    Console.WriteLine($" The sum of {j} column: {colSums[j]}");
}

Console.WriteLine("--------------------------");

Console.WriteLine($" The sum of 1st row: {my2DArray1[0, 0] + my2DArray1[0, 1] + my2DArray1[0, 2] + my2DArray1[0, 3] + my2DArray1[0, 4]}");
Console.WriteLine($"The sum of 2nd row: {my2DArray1[1, 0] + my2DArray1[1, 1] + my2DArray1[1, 2] + my2DArray1[1, 3] + my2DArray1[1, 4]}");
Console.WriteLine($"The sum of 3rd row {my2DArray1[2, 0] + my2DArray1[2, 1] + my2DArray1[2, 2] + my2DArray1[2, 3] + my2DArray1[2, 4]}");

Console.WriteLine();

Console.WriteLine($" The sum of 1st column: {my2DArray1[0, 0] + my2DArray1[1, 0] + my2DArray1[2, 0]}");
Console.WriteLine($"The sum of 2nd column: {my2DArray1[0, 1] + my2DArray1[1, 1] + my2DArray1[2, 1]}");
Console.WriteLine($"The sum of 3rd column: {my2DArray1[0, 2] + my2DArray1[1, 2] + my2DArray1[2, 2]}");
Console.WriteLine($" The sum of 4th column: {my2DArray1[0, 3] + my2DArray1[1, 3] + my2DArray1[2, 3]}");
Console.WriteLine($"The sum of 5th column: {my2DArray1[0, 4] + my2DArray1[1, 4] + my2DArray1[2, 4]}");

/*
Task 1.

Enter numbers until sum of all numbers is larger than 100

Ask user to enter an integer

Read the value from the keyboard

repeat asking to enter more integers, and reading until SUM of all the integers user has entered is larger than 100

*/


Console.WriteLine("******************Task 1************************");

/* int [] myArray = new int [0];
var sum = 0;
do
{
    Console.WriteLine("Please, enter any number from 1 to 100");
    string userNumber2 = Console.ReadLine();
    bool numbParse1 = int.TryParse(userNumber2, out int number1);
    myArray = myArray.Append(number1);
    Console.WriteLine();
    sum += number1;
}
while (sum < 100);
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($" You have entered such number: {myArray[i]}");
}
Console.WriteLine($" You have entered total sum {sum}");
Console.WriteLine();
*/

/*
Task 2.

Number guessing game

Define a new array of 3 integers - initialize the values

 Ask user to enter any integer

If the integer is in the array, print that user guessed right

If the integer is not in the array - print that user guessed wrong

Finish the game, when all 3 numbers are guessed

*/

Console.WriteLine("******************Task 2************************");
/*
int[] myArray3 = { 2, 5, 9, 3};
int guesedNumberCount = 0;
while (guesedNumberCount < myArray3.Length)
{
    // guess number
    int number3 = GuessNumber();

    // does array contains number
    bool isFound = ArrayContainsNumber(myArray3, number3);
    
    // count correct guesses
    guesedNumberCount = CountCorrectGuesses(guesedNumberCount, isFound);
}

bool ArrayContainsNumber(int[] myArray3, int number3)
{
    bool isFound = false;
    for (int i = 0; i < myArray3.Length; i++)
    {
        if (myArray3[i] == number3)
            isFound = true;
    }
    return isFound;
}

int GuessNumber()
{
    Console.WriteLine("Please, enter any number from 1 to 10");
    string userNumber3 = Console.ReadLine();
    bool numbParse2 = int.TryParse(userNumber3, out int number3);
    return number3;
}

int CountCorrectGuesses(int guesedNumberCount, bool isFound)
{
    if (isFound == true)
    {
        guesedNumberCount++;
        Console.WriteLine("You have guessed a right number!");
    }
    else
    {
        Console.WriteLine("You have guessed wrong, please try again");
    }
    return guesedNumberCount;
}

*/

// Task 3. Loops with flags and conditions - output odd numbers, or similar.

Console.WriteLine("******************Task 3************************");

int[] myArray4 = new int[5];
var random = new Random();
for (int i = 0; i < myArray4.Length; i++)
{
    myArray4[i] = random.Next();
    Console.WriteLine($"This array consists of numbers: {myArray4[i]}");
}

Console.WriteLine();
Console.WriteLine("Odd numbers of the array are:");
for (int i = 0; i < myArray4.Length; i++)
{
    var oddCandition = myArray4[i] % 2 != 0;
    if (oddCandition)
    {
        Console.WriteLine($"{myArray4[i]}");
    }
}

Console.WriteLine("*********SuperHeroInfo*************");



