﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livre.Media
{
    public abstract class Item : IItem
    {
        //--------------------------
        //      Champs
        private String _title;
        private int _id;
        private double _price;
        //--------------------------
        //--------------------------
        //      Beans
        public string Title { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        //--------------------------

    }
}
