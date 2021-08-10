using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuário");
            Console.WriteLine("-------------");
            Console.WriteLine("Novo Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Novo Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Nova Bio: ");
            var bio = Console.ReadLine();
            Console.WriteLine("Nova Image: ");
            var image = Console.ReadLine();
            Console.WriteLine("Nova Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = "Hash",
                Bio = bio,
                Image = image,
                Slug = slug

            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuario Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel cadastrar usuário");
                Console.WriteLine(ex.Message);

            }
        }




    }
}