using Core.Models;
using Core;
using System.Reflection.Metadata;

namespace ClassAbstractionsPolymorphismTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title;
            string description;
            string content;
            string choice;
            bool f;
            int id;
            string answer;
            do
            {
                Console.WriteLine("1.Blog yarat");
                Console.WriteLine("0. Proqramdan cix.");

                Console.Write("Secim edin: ");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        do
                        {
                            Console.Write("Title daxil edin: ");
                            title = Console.ReadLine();
                        }
                        while (!title.CheckBlogTitle());

                        do
                        {
                            Console.Write("Description daxil edin: ");
                            description = Console.ReadLine();
                        }
                        while (!description.CheckBlogDescription());

                        Blog blog = new Blog(title, description);

                        do
                        {
                            Console.WriteLine("1. Comment yarat");
                            Console.WriteLine("2. Commentlere bax");
                            Console.WriteLine("3. Commente bax");
                            Console.WriteLine("4. Comment sil");
                            Console.WriteLine("5. Comment deyis");
                            Console.WriteLine("0. Ana menyuya qayit");

                            Console.Write("Secim edin: ");
                            choice = Console.ReadLine();
                            switch (choice)
                            {

                                case "1":

                                    Console.Write("content daxil edin: ");
                                    content = Console.ReadLine();
                                    Comment comment = new Comment(content);
                                    blog.AddComment(comment);
                                    break;
                                case "2":
                                    if (blog.GetAllComments() == null)
                                    {
                                        Console.WriteLine("Comment yoxdur!");
                                    }
                                    else
                                    {
                                        foreach (Comment item in blog.GetAllComments())
                                        {
                                            Console.WriteLine(item);
                                        }
                                    }
                                    break;
                                case "3":
                                    do
                                    {
                                        Console.Write("Id daxil edin: ");
                                    }
                                    while (!int.TryParse(Console.ReadLine(), out id));
                                    Console.WriteLine(blog.GetComment(id));
                                    break;
                                case "4":
                                    do
                                    {
                                        Console.Write("Id daxil edin: ");
                                    }
                                    while (!int.TryParse(Console.ReadLine(), out id));

                                    foreach (Comment item in blog.RemoveComment(id))
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case "5":
                                    do
                                    {
                                        Console.Write("Id daxil edin: ");
                                    }
                                    while (!int.TryParse(Console.ReadLine(), out id));
                                    Console.Write("content daxil edin: ");
                                    content = Console.ReadLine();
                                    Comment commentt = new Comment(content);
                                    blog.UpdateComment(id, commentt);
                                    break;                               
                            }
                        } while (choice != "0");

                        break;
                }
            }
            while (answer != "0");
        }
    }
}