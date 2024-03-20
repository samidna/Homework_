namespace Homework.Models;

public class DiscountPrice
{
    public static double Discount(double price1, double price2, double price3)
    {
        double[] products = { price1, price2, price3 };
        for (int i = 0; i<products.Length; i++)
        {
            if (i==2) break;
            for (int j = i+1; j<products.Length; j++)
            {
                if (products[i]>products[j])
                {
                    double temp = products[i];
                    products[i]=products[j];
                    products[j] = temp;
                }
            }
        }
        return products[1]+products[2];
    }

}
