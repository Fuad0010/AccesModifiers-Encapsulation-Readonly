using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers_Encapsulation_Readonly.Models
{
    internal class User
    {
        public string Name;
        public int Age;
        public string Password;

        public User(string name, int age, string password)
        {
            Name = name;
            Age = age;
            Password = password;
        }
        public void GetInfo()
        {
            Console.WriteLine($"----------------------------\n"+
                              $"Name: {Name}\n" +
                              $"Age: {Age}\n" +
                              $"Password: {Password}");
        }

        
    }
    



}
