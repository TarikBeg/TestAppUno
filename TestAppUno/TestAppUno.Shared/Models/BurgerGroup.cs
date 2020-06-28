﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestAppUno.Model
{
    public class BurgerGroup: ObservableCollection<Burger>
    {
        public int BurgerGroupId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }

        public List<Burger> Burgers
        {
            get;
            set;
        }
    }
}
