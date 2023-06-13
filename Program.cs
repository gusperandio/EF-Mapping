using BlogEF.Data;
using BlogEF.Models;

namespace BlogEF
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();
            using var context = new BlogDataContext();

            var user = new User{
                Bio = "Teste",
                Email = "teste@teste.com",
                Image = "https://teste",
                Name = "Testando",
                PasswordHash = "Password",
                Slug = "SlugTeste"
            };

            context.Users.Add(user);
            context.SaveChanges();

            // var user = context.Users.FirstOrDefault();
            // var post = new Post
            // {
            //     Author = user,
            //     Body = "Meu Artigo",
            //     Category = new Category{
            //         Name = "Backend",
            //         Slug = "backend"
            //     },
            //     CreateDate = DateTime.Now,
            //     Slug = "meu-artigo",
            //     Summary = "Neste artigo só tem testes",
            //     Title = "Meu artigo"
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            //! COMANDO PARA GERAR O SCRIPT DO BANCO
            //todo dotnet ef migrations script -o ./script.sql
        }
    }
}