using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApp.Models
{
    public class Trainer
    {
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Trainer(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
        }

        public void ShowTrainer()
        {
            Console.WriteLine($"Eğitmen: {Name} - Alan: {Specialty}");
        }
    }
}
