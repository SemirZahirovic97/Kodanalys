using System;

namespace Kodanalys
{
    class Program
     {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                
                string choice = Console.ReadLine();
                switch (choice)
                {

                    case "1":
          
                    Console.Write("Ange namn: ");
                    string UserToAdd = Console.ReadLine();
                    UserManager.AddUser(UserToAdd);
                        break;

                    case "2":
                     
                     UserManager.DisplayUsers();

                        break;

                    case "3":
                
                    Console.Write("Ange namn att ta bort: ");
                    string UserToRemove = Console.ReadLine();
                    UserManager.RemoveUser(UserToRemove);
                        break;

                    case "4":
                
                    Console.Write("Ange namn att söka: ");
                    string UserToSearch = Console.ReadLine();
                        UserManager.SearchUser(UserToSearch);

                        break;

                    case "5":
                        
                    isRunning = false;
                        Console.WriteLine("Avslutar programmet.");
                        break;

                    default:
               
                    Console.WriteLine("Ogiltigt val.");
                            break;
                    
                
            }
        }
    }
}
    class UserManager
    {
        private List<string> users = new List<string>();
        private const int maxUsers = 10;
    }
