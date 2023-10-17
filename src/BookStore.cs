using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class BookStore
    {
        private Dictionary<Edition,int> _editionsList;

        public void addEdition(Edition editionToAdd, int count)
        {
            _editionsList.Add(editionToAdd,count);
        }
    }
}
