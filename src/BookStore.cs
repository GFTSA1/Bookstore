﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class BookStore
    {
        private Dictionary<Edition,int> _editionsDict;

        public void addEdition(Edition editionToAdd, int count)
        {
            _editionsDict.Add(editionToAdd,count);
        }

        public BookStore() 
        {
            _editionsDict = new Dictionary<Edition, int> ();
        }
    }
}
