using System;
class QuantityPrice
{
 public static void calculate()
 {
		 Console.Write("Enter the unit price of the item (INR): ");
		 int unitPrice = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Enter the quantity to be bought: ");
		 int quantity = Convert.ToInt32(Console.ReadLine());
		 double totalPrice = unitPrice * quantity;
		 Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity is {quantity} and unit price is INR {unitPrice}");
 }
}