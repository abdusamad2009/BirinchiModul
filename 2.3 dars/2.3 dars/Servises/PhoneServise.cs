using System;
using System.Collections.Generic;
using System.Text;
using _2._3_dars.Models;

namespace _2._3_dars.Servises;

internal class PhoneServise
{
    List<Phone> Phones;

    public Guid PhoneId { get; private set; }

    public PhoneServise()
    {
        Phones = new List<Phone>(); 
    }
    public Guid AddPhone(Phone phone)
    {
        phone.PhoneId = Guid.NewGuid();
        Phones.Add(phone);
        return phone.PhoneId;
    }
    public Phone? GetPhoneById(Guid phoneId)
    {
        foreach(var phone in Phones)
        {
            if(phone.PhoneId == phoneId)
            {
                return phone;
            }
        }
        return null;
    
    }
    public bool DeletePhone(Guid PhoneId)
    {
        foreach (var phone in Phones)
        {
            if (phone.PhoneId == PhoneId)
            {
                Phones.Remove(phone);
                return true;
            }
        }
        return false;
    }
    public List<Phone> GetAllPhones()
    {
        return Phones;
    }

    public bool UpdatePhone(Guid phoneId, Phone newPhone)
    {
        for (var i = 0; i < Phones.Count; i++)
        {
            if (Phones[i].PhoneId == PhoneId)
            {
                Phones[i].Model = newPhone.Model;
                Phones[i].Brand = newPhone.Brand;
                Phones[i].Price = newPhone.Price;
                Phones[i].Color = newPhone.Color;
                return true;

            }
        }
        return false;
    }
    

    

}
