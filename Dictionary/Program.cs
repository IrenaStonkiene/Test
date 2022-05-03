// See https://aka.ms/new-console-template for more information

Dictionary<string, float> productPrice = new Dictionary<string, float>();

productPrice.Add("Bread", 1.1f);
productPrice.Add("Butter", 1.5f);
productPrice.Add("Cheese", 2.3f);
productPrice.Add("Milk", 1.1f);
productPrice.Add("Yougurt", 0.5f);
productPrice.Add("Water", 0.75f);
productPrice.Add("Cake", 2.8f);
productPrice.Add("Kandy", 1.65f);

foreach(var item in productPrice)
{
    Console.WriteLine($"{item.Key}: {item.Value});
}
