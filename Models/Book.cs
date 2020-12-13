using System;

namespace Bookshelf.Models
{
    public class Book
    {

        // public Book(string name, string author, DateTime date){
        //     id = Guid.NewGuid();
        //     this.name = name;
        //     this.author = author;
        //     this.dateCompleted = date;
        // }

        public Guid Id {get; set;}
        public string name { get; set; }
        public string author { get; set; }
        public DateTime dateCompleted { get; set; }
    }
}