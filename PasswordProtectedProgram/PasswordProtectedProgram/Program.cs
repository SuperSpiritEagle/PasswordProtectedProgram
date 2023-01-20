using System;

namespace PasswordProtectedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = "secret Message";
            string pincode;
            string password = "123";
            int numberAttempts = 3;


            for (int i = numberAttempts;i>0;i--)
            {
                Console.WriteLine("Введите пароль чтобы прочитать тайное сообщение");
                Console.WriteLine($"количество попыток {i}");

                pincode = Console.ReadLine();

                if (pincode == password)
                {
                    Console.WriteLine(secretMessage);
                    break;
                }
            }
        }
    }
}
