using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht2._1.Model;

namespace Opdracht2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "http://www.nerdesinsema.nl" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} Records zijn toegevoegd in de database", count);

                Console.WriteLine();
                Console.WriteLine("Blogs in de database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }

                
                var test = from blog in db.Blogs
                           orderby blog.BlogId
                           where blog.Url == "https://www.alperen.nl"
                           select blog;

                Console.WriteLine("Handmatig toegevoegde data:");
                foreach (var blog in test)
                {
                    Console.WriteLine(blog.Url);
                }

            }
        }
    }
}
