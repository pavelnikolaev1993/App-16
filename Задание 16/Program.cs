using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Задание_16;

const int n = 5;
Product[] products = new Product[n];
for (int i = 0; i < n; i++)
{
Console.WriteLine("Введите код товара");
int code = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите название товара");
    string name = Console.ReadLine();
Console.WriteLine("Введите цену товара");
double price = Convert.ToDouble(Console.ReadLine());
products[i] = new Product() { Code = code, Name = name, Price = price };
}
JsonSerializerOptions options = new JsonSerializerOptions()
{
    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
    WriteIndented = true
};
string JsonString = JsonSerializer.Serialize(products, options);

using (StreamWriter sw = new StreamWriter("../../../../Products.json"))
{
    sw.WriteLine(JsonString);
}


