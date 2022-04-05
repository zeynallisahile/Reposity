using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Library
    {
        public List<Book> BookList;
        public List<Book> FilterByPrice(int minPrice,int maxPrice)
        {
            var filteredByPrice = BookList.FindAll(b => b.Price >= minPrice && b.Price <= maxPrice);
            if (filteredByPrice.Count == 0)
                throw new Exception("Xeta");
            return filteredByPrice;

        }

        public List<Book>FindByGenre( Genre genre)
        {
            return BookList;
        }

        public static void FindBookByNo(int no)
        {

        }
    }
}
