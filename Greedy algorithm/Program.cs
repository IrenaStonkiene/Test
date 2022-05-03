double amount = 0;

int[] coins = { 200, 100, 50, 10, 5, 2, 1 };
string[] names = { "2 euro", "1 euro", "50 cents", "10 cents", "5 cents", "2 cents", "1 cent" }; 

Console.WriteLine("Please, enter the amount given to the clerk");
string amountString = Console.ReadLine();
bool amountParsed = double.TryParse(amountString, out amount);
var amountinCents = (int)(amount * 100);

double price = 0;
Console.WriteLine("Please, enter the cost of the product");
string priceString = Console.ReadLine();
bool priceParsed = double.TryParse(priceString, out price);
var priceinCents = (int)(price * 100);

int change =  amountinCents - priceinCents;
Console.WriteLine($"Your change is {change}");

for (int i = 0; i < coins.Length; i++)
{
    var coincount = change / coins[i];
    change = change % coins[i];
    Console.WriteLine($"{coincount} in {names[i]} coins");
}







