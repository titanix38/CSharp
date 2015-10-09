using Livre.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livre
{
    class Program
    {
        static void Main(string[] args)
        {
            BookCategory cat = new BookCategory();

            Publisher publish1 = new Publisher { Nom = "Casterman" };
            Author author1 = new Author { Name = "Rowling", FirstName = "Johannes" };
            Book livre1 = new Book { Title = "C#", Lang = "FR-fr", NbPage = 450,Cat=BookCategory.SF };

            livre1.addAuthor(author1, 0);

        }
    }
}
