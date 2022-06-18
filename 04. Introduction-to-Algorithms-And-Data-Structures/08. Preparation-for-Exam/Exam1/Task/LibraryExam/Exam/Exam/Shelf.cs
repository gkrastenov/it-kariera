using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam
{
    public class Shelf
    {
        private Book head;
        private Book tail;
        private int count;
        private List<string> special;//head
        private List<string> books;//tail

        public Book Head
        {
            get { return this.head; }
            set { this.head = value; }
        }
        public Book Tail
        {
            get { return this.tail; }
            set { this.tail = value; }
        }
        public int Count 
        {
            get { return this.count; }
            set { this.count = value; }
        }
        
        public Shelf()
        {
            special = new List<string>();
            books = new List<string>();
        }

        public void AddBook(string bookId)
        {
            this.books.Add(bookId);
            this.Count++;
        }

        public void AddSpecialBook(string bookId)
        {
            this.special.Add(bookId);
            this.Count++;
        }

        public Book CheckBookIsPresent(string bookId)
        {
            Book b = new Book(bookId);
            if (this.books.Contains(bookId))
            {
                return b;
            }
            else if (this.special.Contains(bookId))
            {
                return b;
            }
            else 
            {
                return default(Book);
            }
        }

        public bool ReleaseBook(string bookId)
        {
            if (this.books.Remove(bookId))
            {
                this.Count--;
                return true;
            }
            else if (this.special.Remove(bookId))
            {
                this.Count--;
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ReleaseBook(int index)
        {
            bool flag = false;
            for (int i = 0; i < this.books.Count; i++)
            {
                if (i == index)
                {
                    try
                    {
                        this.books.Remove(this.books[i]);
                        this.Count--;
                        flag = true;
                        break;
                    }
                    catch (Exception)
                    {
                        flag = false;
                    }
                }
            }
            if (flag == false)
            {
                for (int i = 0; i < this.special.Count; i++)
                {
                    if (i == index)
                    {
                        try
                        {
                            this.special.Remove(this.special[i]);
                            this.Count--;
                            flag = true;
                            break;
                        }
                        catch (Exception)
                        {
                            flag = false;
                        }
                    }
                }
            }
            return flag;
        }

        public void ShelfInformation()
        {
            if (this.books.Count == 0 && this.special.Count == 0)
            {
                Console.WriteLine("Shelf is empty!");
            }
            else
            {
                if (this.special.Count != 0)
                {
                    for (int i = special.Count-1; i >= 0 ; i--)
                    {
                        Console.WriteLine("Book: " + special[i]);
                    }
                }
                if (this.books.Count != 0)
                {
                    foreach (var b in this.books)
                    {
                        Console.WriteLine("Book: " + b);
                    }
                }
            }
            
        }
    }
}
