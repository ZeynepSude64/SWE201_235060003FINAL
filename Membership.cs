using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApp.Models
{
    public class Membership
    {
        public string Type { get; set; }
        public decimal Price { get; set; }

        public Membership(string type, decimal price)
        {
            Type = type;
            Price = price;
        }

        public void ShowMembership()
        {
            Console.WriteLine($"Üyelik Türü: {Type}, Ücret: {Price}₺");
        }
    }
}

