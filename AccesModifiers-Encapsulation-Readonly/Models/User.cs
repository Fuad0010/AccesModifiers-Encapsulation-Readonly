using System;

namespace AccesModifiers_Encapsulation_Readonly.Models
{
    internal class User
    {
        public string Name;
        public int _age;
        public string _password;

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public string name
        {
            get { return name; }

            set { name = value; }
        }

        public int Age
        {
            get { return _age; }

            set
            {
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Age invalid: ");
                        return;
                    }
                }
                _age = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                {
                    if (String.IsNullOrEmpty(value) == false && value.Length >= 8 == true && DifferentCase(value) == true)
                    {
                        _password = value;
                        return;
                    }
                    Console.WriteLine("Password invalid. Please try again: \n");
                    return;
                }
            }
        }


        public bool DifferentCase(string pass)
        {
            char[] arr = pass.ToCharArray();
            bool result = false;
            bool result1 = false;
            bool result2 = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (result1 != char.IsUpper(arr[i]))
                {
                    result = true;
                }
                if (result2 != char.IsNumber(arr[i]))
                {
                    result = true;
                }
                if (result1 == true && result2 == true)
                {
                    result = true;
                }
            }
            return result;


        }
        public void Info()
        {
            Console.WriteLine("User info");
        }




    }




}
