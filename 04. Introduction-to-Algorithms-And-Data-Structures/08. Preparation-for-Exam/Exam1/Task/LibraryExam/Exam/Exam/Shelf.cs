using System.Text;

namespace Exam
{
    public class Shelf // represend linked list
    {
        // fields:
        private Book head; // първа в поредицата
        private Book tail; // последна в поредицата

        public Shelf()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        // брой книги
        public int Count { get; private set; }

        // Time complexity: O(1)
        // Space comp.: O(1)
        public void AddBook(string bookId)
        {
            Book newBook = new Book(bookId);

            // има 0 добавени книги
            if (Count == 0)
            {
                head = newBook;
                tail = newBook;
            }
            else
            {
                // има само 1 добавена книга
                if (Count == 1)
                {
                    head.Next = newBook;
                    tail = newBook;
                }
                else // има поне 2 добавени книги
                {
                    tail.Next = newBook;
                    tail = newBook;
                }
            }
            Count++;
        }

        public void AddSpecialBook(string bookId)
        {
            Book newBook = new Book(bookId);
            if (Count == 0)
            {
                head = newBook;
                tail = newBook;
            }
            else
            {
                newBook.Next = head;
                head = newBook;
            }
            Count++;
        }

        public Book CheckBookIsPresent(string bookId)
        {
            var currentBook = head;
            while (currentBook != null)
            {
                if (currentBook.BookId == bookId)
                    return currentBook;
                currentBook = currentBook.Next;
            }
            return null;
        }

        public bool ReleaseBook(string bookId)
        {
            if (Count == 0)
                return false;

            if(head.BookId == bookId)
            {
                if (Count == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                }
                
                Count--;
                return true;
            }

            var currentBook = head;
            while (currentBook != null)
            {
                if (currentBook.Next != null)
                {
                    if (currentBook.Next.BookId == bookId)
                    {
                        currentBook.Next = currentBook.Next.Next;                      
                        Count--;

                        if (Count == 1)
                            tail = head;
                        else tail = currentBook.Next;

                        return true;
                    }
                }
                currentBook = currentBook.Next;
            }
            return false;
        }

        public bool ReleaseBook(int index)
        {
            if (index < 0 || index >= Count)
                return false;

            if(index == 0)
            {
                if(Count == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                }
                Count--;
                return true;
            }

            int currentIndex = 0;
            var currentBook = head;
            while (currentBook != null)
            {
                if (currentIndex == index - 1)
                {
                    if (currentBook.Next != null)
                        currentBook.Next = currentBook.Next.Next;
                    Count--;
                    return true;
                }
                currentIndex++;
                currentBook = currentBook.Next;
            }

            return false;
        }

        // Time complexity: O(n) n -> броя книги
        // Space comp.: O(n)  n -> броя книги
        public StringBuilder ShelfInformation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (Count == 0)
            {
                stringBuilder.Append("Shelf is empty!");
                return stringBuilder;
            }

            // linear search
            var currentBook = head;
            while (currentBook != null)
            {
                stringBuilder.AppendLine(currentBook.ToString());
                currentBook = currentBook.Next;
            }
            return stringBuilder;
        }
    }
}