using AccesModifiers_Encapsulation_Readonly.Models;
using System;

namespace AccesModifiers_Encapsulation_Readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = 1;
            
            User[] user = new User[count1];
            for (int i = 0; i < count1; i++)
            {

                string name = GetInputWord("Please enter the name: ",1,20);

                int age = GetInputInt("Please enter the age: ", 1, 100);

                string password = GetInputWord("Password: ", 8, 100);

                user[i] = new User(name, age, password)
                {
                    Name = name,
                    Age = age,
                    Password = password
                };

            }
            foreach (var item in user)
            {
                item.GetInfo();
            }        
        
        
        }
            static int GetInputInt(string name, int minValue, int maxValue)
        {


            int input;

            do
            {
                Console.Write(name);
                input = Convert.ToInt32(Console.ReadLine());

            } while (input < minValue || input > maxValue);
            return input;
        }

        static string GetInputWord(string name, int minValue, int maxValue)
        {


            string input;

            do
            {
                Console.Write(name);
                input = Console.ReadLine();

            } while (input.Length < minValue || input.Length > maxValue);
            return input;
        }







    }
}
