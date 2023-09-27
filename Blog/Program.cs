using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext())
            {
                // Criando um obj

                //var tag = new Tag { Name = "Asp.Net", Slug = "aspnet" };
                //context.Tags.Add(tag);
                //context.SaveChanges();

                // Mudando o nome e Slug pelo Id

                //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                //tag.Name = "ASP.Net";
                //tag.Slug = "aspnet";

                // context.Update(tag);
                // context.SaveChanges();

                // Crtl + K + C comenta várias linhas, Crtl + K + U descomenta

                //var tag = context.tags.firstordefault(x => x.id == 1);

                //context.remove(tag);
                //context.savechanges();

                //var tags = context.Tags
                //    .AsNoTracking() // Somente em leitura, Update e Delete não usar
                //    .ToList();

                //foreach(var tag in tags)
                //{
                //    Console.WriteLine(tag.Name );
                //}

                //var tag = context
                //    .Tags
                //    .AsNoTracking()
                //    .FirstOrDefault(x => x.Id == 1);

                //Console.WriteLine(tag?.Name);

                // Adiciona um Usuário no Banco
                //context.Users.Add(new User
                //{
                //    Bio = "Analista Júnior",
                //    Email = "mica@jr.io",
                //    Image = "https://www.linkedin.com/in/micaildejr/",
                //    Name = "Micailde Júnior",
                //    PasswordHash = "1234",
                //    Slug = "mica-jr"
                //});
                //context.SaveChanges();

                // Alterando os dados do Usuário
                //var user = context.Users.FirstOrDefault();
                //var post = new Post
                //{
                //    Author = user,
                //    Body = "Meu artigo",
                //    Category = new Category
                //    {
                //        Name = "Teste1",
                //        Slug = "teste1"
                //    },
                //    CreateDate = DateTime.Now,
                //    // LastUpdateDate=
                //    Slug = "meu-artigo",
                //    Summary = "Neste artigo vamos conferir...",
                //    // Tags = null,
                //    Title = "Meu artigo"
                //};
                //context.Posts.Add(post);
                //context.SaveChanges();

                //var user = new User
                //{
                //    Name = "Grogu",
                //    Email = "grogu@gmail.com",
                //    GitHub = "grogu",
                //    Bio = "Morning Star",
                //    Image = "https://",
                //    PasswordHash = "1234",
                //    Slug = "grogu"
                //};

                //context.Users.Add(user);
                //context.SaveChanges();
            }
        }
    }
}
