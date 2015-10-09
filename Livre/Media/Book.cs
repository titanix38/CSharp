using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livre.Media
{
    public class Book : Media
    {
        //----------------------------------------------------------------------------------
        //                                  CHAMPS
        private string nom;
        private int id;
        private string title;

        private string isbn;
        private int nbPage;
        // private Date date;
        private string lang;   // code ISO	
        private Author[] authors = new Author[10];
        private int numberAuthor;
        private BookCategory cat;

        private Publisher publish;
        //----------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------
        //                                  BEAN
        public string Title { get; set; }
        public string Lang { get; set; }
        public string Isbn { get; set; }
        public int NbPage { get; set; }
        public Publisher Publish { get; set; }

        internal BookCategory Cat { get; set; }

        //----------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------
        //                                  METHODES
        public void addAuthor(Author a,int i)
        {
            authors[i] = a;
        }
        //----------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------

        public override double getVATPrice()
        {
            return (Price * 1.05);
        }

        public string toString()
        {
            string about = "Livre :\n\r";
            about += " Titre   : " + this.Title + "\n";
            about += " Nb page : " + this.nbPage + "\n";
            return about;
        }
        //----------------------------------------------------------------------------------
    }

}
