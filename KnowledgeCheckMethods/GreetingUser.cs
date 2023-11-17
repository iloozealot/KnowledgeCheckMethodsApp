using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheckMethods
{
    public static class GreetingUser
    {
        public static string name;
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the application User.");
        }
        public static void GetUsersName()
        {
            Console.Write("What is your name: ");
            name = Console.ReadLine();
        } 
        public static void HelloUser()
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}
