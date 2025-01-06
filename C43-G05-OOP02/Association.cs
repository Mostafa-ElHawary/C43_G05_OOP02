using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02
{
    // Book has a author

    public class  Library {
        public string Name { get; set; }
        public Book[] Books { get; set; }

    }
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Author Author { get; set; }

        public Book(Author author)
        {
            Author = author;

        }
    }
    public class Author 
    {
        public int ID { get; set; }
        public string Name { get; set; }
    
        
    }
}
