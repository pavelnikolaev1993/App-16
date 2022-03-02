using System.IO;
using System.Text.Json;
using Задание_16;
string jsonString = String.Empty;
using (StreamReader sr = new StreamReader("../../../../Products.json"))
{
    jsonString = sr.ReadToEnd();
}
Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

Product maxProduct = products[0];
foreach (Product a in products)
{
    if (a.Price > maxProduct.Price)
    {
        maxProduct = a;
    }
}
Console.WriteLine($"{maxProduct.Code}, {maxProduct.Name}, {maxProduct.Price}");


