
using Homework.Models;
#region TASK-1
Console.Write("Birinci arraye daxil edeceyiniz eded sayini daxil edin : ");
int count = int.Parse(Console.ReadLine());
int[] arr1 = new int[count];
for(int i=0; i<count; i++)
{
    Console.Write($"{i+1}.ededi daxil edin : ");
    arr1[i] = int.Parse(Console.ReadLine());
}
Console.Write("Ikinci arraye daxil edeceyiniz eded sayini daxil edin : ");
int count1 = int.Parse(Console.ReadLine());
int[] arr2 = new int[count1];
for(int j=0;j<count1; j++)
{
    Console.Write($"{j+1}.ededi daxil edin : ");
    arr2[j] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Birinci arrayde olub ikinci arrayde olmayan ededler : ");
Number.DifferenceNumbers(arr1, arr2);
#endregion

#region TASK-2
//Console.Write("Masin adini daxil edin : ");
//string name = Console.ReadLine();
//Console.Write("Masin qiymetini daxil edin : ");
//double price = double.Parse(Console.ReadLine());
//Console.Write("Masin sayini daxil edin : ");
//int count = int.Parse(Console.ReadLine());
//Product product = new(name,price,count);

//product.Sell();
#endregion

#region TASK-3
//Console.Write("Username daxil edin : ");
//string userName = Console.ReadLine();
//Console.Write("Shifreni daxil edin : ");
//string password = Console.ReadLine();
//User user = new(userName, password);
#endregion

#region TASK-4
//Console.Write("Daxil edeceyiniz bal sayini daxil edin : ");
//int count = int.Parse(Console.ReadLine());
//int[] scores = new int[count];
//for(int i=0;i<count; i++)
//{
//    Console.Write($"{i+1}.bali daxil edin : ");
//    scores[i] = int.Parse(Console.ReadLine());
//}
//Average_Method.CalcAvg(scores);
#endregion

#region TASK-5
//Console.WriteLine("Istediyiniz mehsullarin qiymetlerini daxil edin : ");
//Console.Write("Birinci mehsulun qiymeti : ");
//double price1 = double.Parse(Console.ReadLine()); 
//Console.Write("Ikinci mehsulun qiymeti : ");
//double price2 = double.Parse(Console.ReadLine()); 
//Console.Write("Ucuncu mehsulun qiymeti : ");
//double price3 = double.Parse(Console.ReadLine());
//double result = DiscountPrice.Discount(price1, price2, price3);
//Console.WriteLine("Endirimli qiymet : "+result);
#endregion
