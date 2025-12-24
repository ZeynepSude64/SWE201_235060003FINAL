using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public Member(int id, string fullName, int age)
        {
            Id = id;
            FullName = fullName;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Üye: {FullName}, Yaş: {Age}");
        }
    }
}
