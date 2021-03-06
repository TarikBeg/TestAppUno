﻿using System.Collections.Generic;

namespace TestAppUno.Model
{
    public class Burger
    {
        public int BurgerId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string ShortDescription
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }

        public bool Available
        {
            get;
            set;
        }

        public int PrepTime
        {
            get;
            set;
        }

        public List<string> Ingredients
        {
            get;
            set;
        }

        public bool IsFavorite
        {
            get;
            set;
        }

        public string GroupName
        {
            get;
            set;
        }

        public string Title { get; set; }
    }
}
