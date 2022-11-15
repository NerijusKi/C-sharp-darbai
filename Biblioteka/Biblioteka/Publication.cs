using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Publication
    {
        public Publication(string isbn)
        {
            ISBN = isbn;
        }


        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public int PageCount { get; set; }
        
    }
}
