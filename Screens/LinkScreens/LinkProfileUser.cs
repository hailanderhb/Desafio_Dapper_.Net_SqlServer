using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.LinkScreens
{
    public static class LinkProfileUser
    {
        public static void Load()
        {
            Linker();

        }
        public static void Linker()
        {

            var repository = new UserRepository(Database.Connection);
            var items = repository.GetWithRoles();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($" - {role.Name} - {role.Slug}");
                }
            }
        }
    }
}