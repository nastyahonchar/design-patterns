namespace BookShopDI.Helpers;

public class DiscountService
{
    public double ApplyDiscount(double price, int itemCount)
    {
        if (itemCount >= 3)
        {
            Console.WriteLine("Applying 10% discount for 3+ items...");
            return price * 0.9;
        }
        Console.WriteLine("No discount applied.");
        return price;
    }
}