using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livre.Media
{
    public abstract class  Media : Item
    {
        //--------------------------
        //      Champs
        private Publisher _house;
        //private Date year;
        private Author[] _authors = new Author[10];
        private int _nbAut = 0;
        private String[] _lang = new String[10];
        private double _price;
        //--------------------------
        //--------------------------
        //      Beans
        
        //--------------------------
        //      Others Methods
        public abstract double getVATPrice();
        //--------------------------

    }

}
