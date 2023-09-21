using Blog.Data;
using System.Linq;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext())
            {
                // Criando um obj

                /*var tag = new Tag { Name = "Asp.Net", Slug = "aspnet" };
                context.Tags.Add(tag);
                context.SaveChanges();*/

                // Mudando o nome e Slug pelo Id
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // tag.Name = "ASP.Net";
                // tag.Slug = "aspnet";

                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);

                // context.Remove(tag);
                // context.SaveChanges();
            }
        }
    }
}
