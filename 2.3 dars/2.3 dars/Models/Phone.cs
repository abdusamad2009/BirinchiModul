using System;
using System.Collections.Generic;
using System.Text;
using _2._3_dars.Servises;

namespace _2._3_dars.Models;

internal class Phone
{
    public Guid PhoneId { get; set; }
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }

    public Phone(string color, string model, decimal price, string brand)
    {
        Color = color;
        Model = model;
        Brand = brand;
        Price = price;
        
    }

    public Phone()
    {
    }
}
