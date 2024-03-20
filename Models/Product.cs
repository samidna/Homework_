namespace Homework.Models;

public class Product
{
    public string Name;
    public double Price;
    public int Count;
    public double TotalIncome;

    public Product(string name,double price,int count)
    {
        Name=name;
        Price = price;
        Count = count;
    }

    public void Sell()
    {
        Count--;
        TotalIncome+=Price;
        Console.WriteLine($"Masin adi : {Name} \nMasin sayi : {Count} \nToplam qiymet : {TotalIncome}");
    }

}
