using System;

namespace MVCApp.Models;

public class Books
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public Books(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    public void ApplyDiscount(double percentage)
    {
        if (percentage < 0 || percentage > 100)
            throw new ArgumentException("Discount must be between 0 and 100");
        Price = Price - (percentage / 100);
        
    }
}
