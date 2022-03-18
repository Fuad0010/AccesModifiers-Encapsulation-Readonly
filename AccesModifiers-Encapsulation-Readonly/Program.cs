using AccesModifiers_Encapsulation_Readonly.Models;
using System;

namespace AccesModifiers_Encapsulation_Readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Username: ");
            string username = Console.ReadLine();

            Console.Write("Please enter the password: ");
            string password = Console.ReadLine();

            Console.Write("Please enter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            User user1 = new User(username, password);

            user1.Info();
            user1.Age = age;




        }
    }
}
