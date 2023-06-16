using LibrarySystem;

Library library = new Library(5);

Book book1 = new Book { Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", Year = 1997 };
Book book2 = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 };
Book book3 = new Book { Title = "1984", Author = "George Orwell", Year = 1949 };

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

Console.WriteLine("Total books in the library: " + library.Count);

Console.WriteLine("\nBooks containing 'Potter':");
Book[] foundBooks = library.FindBook("Potter");
PrintBooks(foundBooks);

library.RemoveBook(book2);

Console.WriteLine("\nTotal books in the library after removal: " + library.Count);

void PrintBooks(Book[] books)
{
    if (books.Length == 0)
    {
        Console.WriteLine("No books found.");
        return;
    }

    foreach (Book book in books)
    {
        Console.WriteLine("Title: " + book.Title);
        Console.WriteLine("Author: " + book.Author);
        Console.WriteLine("Year: " + book.Year);
        Console.WriteLine("---------------------------");
    }
}


namespace LibrarySystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    public class Library
    {
        private Book[] books;

        public Library(int capacity)
        {
            books = new Book[capacity];
        }

        public Book this[int index]
        {
            get
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return books[index];
            }
            set
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                books[index] = value;
            }
        }

        public int Count
        {
            get { return books.Length; }
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                    return;
                }
            }

            Console.WriteLine("The library is full. Unable to add the book.");
        }

        public void RemoveBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == book)
                {
                    books[i] = null!;
                    return;
                }
            }

            Console.WriteLine("Book not found in the library. Unable to remove.");
        }

        public Book[] FindBook(string searchTerm)
        {
            Book[] foundBooks = Array.FindAll(books, b =>
                b != null && (b.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                              b.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)));

            return foundBooks;
        }
    }
}