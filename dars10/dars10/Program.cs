using System.Diagnostics.Metrics;
using static dars10.computer;

namespace dars10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone  phone = new Phone();

            phone.Color = "Black";
            phone.Model = "Lenovo";
            phone.Brand = "Aspire 717-77";
            phone.ManifacturedYrar = 100;
            phone.Storage = 1024;

            Phone phone1 = new Phone()
            {
                Color = "Blue",
                Model = "S20 ultra",
                Brand = "Samsung",
                ManifacturedYrar = 2023,
                Storage = 1024,
                


            };

            Computer computer2 = new Computer();

            computer2.Colour = "Black";
            computer2.Name = "Lenovo";
            computer2.Description = "Aspire 717-77";
            computer2.Memory = 100;
            computer2.Size = 24;


            Computer computer = new Computer()
            {
                Colour = "Grey",
                Name = "Acer",
                Description = "Aspire 515-57",
                Memory = 150,
                Size = 32


            };

            Country country1 = new Country()
            {
                Name = "Uzbekistan",
                Capital = "Tashkent",
                Population = 38000000,
                President = "Shavkat Mirziyoyev",
                Language = "Uzbek",
                Area = 448978

            };

            Country country2 = new Country();
            country2.Name = "Turkey";
            country2.Capital = "Ankara";
            country2.Population = 85664944;
            country2.President = "Rejab Erdogan";
            country2.Language = "Turkish";
            country2.Area = 783562;

        }




    }
}

}