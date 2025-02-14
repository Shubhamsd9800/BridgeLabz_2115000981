using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    abstract class LibraryItem
    {
        private string itemId;
        private string title;
        private string author;
        public LibraryItem(string itemId, string title, string author)
        {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
        }

        public string ItemId { get { return itemId; } }
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public abstract int GetLoanDuration();
        public virtual void GetItemDetails()
        {
            Console.WriteLine($"Item ID: {itemId}, Title: {title}, Author: { author}");
        }
    }

    interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }

    class Book : LibraryItem, IReservable
    {
        public Book(string itemId, string title, string author) :
        base(itemId, title, author)
        { }
        public override int GetLoanDuration()
        {
            return 14; // 14 days loan period
        }
        public void ReserveItem()
        {
            Console.WriteLine($"Book '{Title}' has been reserved.");
        }
        public bool CheckAvailability()
        {
            return true; // Assume always available for simplicity
        }
    }

    class Magazine : LibraryItem
    {
        public Magazine(string itemId, string title, string author) :
        base(itemId, title, author)
        { }
        public override int GetLoanDuration()
        {
            return 7; // 7 days loan period
        }
    }

    class DVD : LibraryItem, IReservable
    {
        public DVD(string itemId, string title, string author) :
        base(itemId, title, author)
        { }
        public override int GetLoanDuration()
        {
            return 5; // 5 days loan period
        }
        public void ReserveItem()
        {
            Console.WriteLine($"DVD '{Title}' has been reserved.");
        }
        public bool CheckAvailability()
        {
            return false; // Assume not available for simplicity
        }
    }
}
