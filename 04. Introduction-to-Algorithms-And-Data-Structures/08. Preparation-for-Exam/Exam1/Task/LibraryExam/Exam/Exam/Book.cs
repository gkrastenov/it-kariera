namespace Exam
{
    public class Book
    {
        public Book(string bookId)
        {
            BookId = bookId;
            Next = null;
        }

        public string BookId { get; private set; }

        public Book Next { get; set; }

        public override string ToString()
        {
            return $"Book: {BookId}";
        }
    }
}