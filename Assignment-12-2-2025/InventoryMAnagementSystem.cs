using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMAnagementSystem
{
    public class Item
    {
        public string ItemName;
        public string ItemID;
        public int Quantity;
        public double Price;
        public Item Next;
        public Item(string itemName, string itemID, int quantity, double
        price)
        {
            ItemName = itemName;
            ItemID = itemID;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }
    class Inventory
    {
        private Item head;
        public void AddItemAtBeginning(string itemName, string itemID, int quantity, double price)
        {
            Item newItem = new Item(itemName, itemID, quantity, price);
            newItem.Next = head;
            head = newItem;
        }
        public void AddItemAtEnd(string itemName, string itemID, int quantity, double price)
        {
            Item newItem = new Item(itemName, itemID, quantity, price);
            if (head == null)
            {
                head = newItem;
                return;
            }
            Item temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newItem;
        }
        public void RemoveItem(string itemID)
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }
            if (head.ItemID == itemID)
            {
                head = head.Next;
                return;
            }
            Item temp = head;
            while (temp.Next != null && temp.Next.ItemID != itemID)
                temp = temp.Next;
            if (temp.Next == null)
            {
                Console.WriteLine("Item not found");
                return;
            }
            temp.Next = temp.Next.Next;
        }
        public void UpdateQuantity(string itemID, int newQuantity)
        {
            Item temp = head;
            while (temp != null)
            {
                if (temp.ItemID == itemID)
                {
                    temp.Quantity = newQuantity;
                    Console.WriteLine("Quantity updated successfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }

        public void SearchItem(string itemID)
        {
            Item temp = head;
            while (temp != null)
            {
                if (temp.ItemID == itemID)
                {
                    Console.WriteLine($"Item ID: {temp.ItemID}, Name:  { temp.ItemName}, Quantity: { temp.Quantity}, Price: { temp.Price}  ");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }
        public void SearchItemByName(string itemName)
        {
            Item temp = head;
            while (temp != null)
            {
                if (temp.ItemName.Equals(itemName,
                StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Item ID: {temp.ItemID}, Name:{ temp.ItemName}, Quantity: { temp.Quantity}, Price: { temp.Price}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }
        public void DisplayTotalInventoryValue()
        {
            double totalValue = 0;
            Item temp = head;
            while (temp != null)
            {
                totalValue += temp.Price * temp.Quantity;
                temp = temp.Next;
            }
            Console.WriteLine($"Total Inventory Value: {totalValue}");
        }

        public void DisplayAllItems()
        {
            if (head == null)
            {
                Console.WriteLine("No items in inventory.");
                return;
            }
            Item temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Item ID: {temp.ItemID}, Name:{ temp.ItemName}, Quantity: { temp.Quantity}, Price: { temp.Price} ");
            temp = temp.Next;
            }
        }
    }
}
