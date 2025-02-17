using System;

namespace LibraryManagementSystem
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public string BookID;
        public bool IsAvailable;
        public Book Next;
        public Book Prev;

        public Book(string title, string author, string genre, string bookID, bool isAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookID = bookID;
            IsAvailable = isAvailable;
            Next = null;
            Prev = null;
        }
    }

    public class Library
    {
        private Book head;
        private Book tail;
        private int count = 0;

        public void AddBookAtEnd(string title, string author, string genre, string bookID, bool isAvailable)
        {
            Book newBook = new Book(title, author, genre, bookID, isAvailable);
            if (head == null)
            {
                head = tail = newBook;
            }
            else
            {
                tail.Next = newBook;
                newBook.Prev = tail;
                tail = newBook;
            }
            count++;
        }

        public void RemoveBook(string bookID)
        {
            Book current = head;
            while (current != null)
            {
                if (current.BookID == bookID)
                {
                    if (current.Prev != null)
                        current.Prev.Next = current.Next;
                    else
                        head = current.Next;

                    if (current.Next != null)
                        current.Next.Prev = current.Prev;
                    else
                        tail = current.Prev;

                    count--;
                    Console.WriteLine("Book removed successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Book not found.");
        }

        public void SearchBook(string searchParam)
        {
            Book current = head;
            bool found = false;
            while (current != null)
            {
                if (current.Title == searchParam || current.Author == searchParam)
                {
                    Console.WriteLine($"Found Book: {current.Title}, Author: {current.Author}, Genre: {current.Genre}, ID: {current.BookID}, Available: {current.IsAvailable}");
                    found = true;
                }
                current = current.Next;
            }
            if (!found)
                Console.WriteLine("No matching books found.");
        }

        public void DisplayBooks()
        {
            Book current = head;
            Console.WriteLine("Books in Library (Forward Order):");
            while (current != null)
            {
                Console.WriteLine($"{current.Title} - {current.Author} - {current.Genre} - {current.BookID} - Available: {current.IsAvailable}");
                current = current.Next;
            }
        }

        public void DisplayBooksReverse()
        {
            Book current = tail;
            Console.WriteLine("Books in Library (Reverse Order):");
            while (current != null)
            {
                Console.WriteLine($"{current.Title} - {current.Author} - {current.Genre} - {current.BookID} - Available: {current.IsAvailable}");
                current = current.Prev;
            }
        }

        public void UpdateAvailability(string bookID, bool newStatus)
        {
            Book current = head;
            while (current != null)
            {
                if (current.BookID == bookID)
                {
                    current.IsAvailable = newStatus;
                    Console.WriteLine("Book availability status updated successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Book not found.");
        }

        public void CountBooks()
        {
            Console.WriteLine($"Total books in library: {count}");
        }
    }

}
