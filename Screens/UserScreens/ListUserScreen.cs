using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuarios:");
            Console.WriteLine("-------------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();

        }

        public static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Email} - {item.PasswordHash} - {item.Bio} - {item.Image} - {item.Slug}");
            }

        }
    }
}
