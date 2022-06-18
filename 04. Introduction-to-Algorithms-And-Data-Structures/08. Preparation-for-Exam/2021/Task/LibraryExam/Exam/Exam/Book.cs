using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class Book
    {
        private string bookId;
        private Book next;
        
        public Book(string bookId)
        {
            this.BookId = bookId;
        }

        public string BookId 
        {
            get { return this.bookId; }
            set { this.bookId = value; }
        }

        public Book Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public override string ToString()
        {
            return this.BookId;
        }
    }
}
