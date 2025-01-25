using System;

class UserInputFeeDiscount {

    public static void discount() {
        Console.Write("Enter the course fee: ");
        int courseFee = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the course discount percentage: ");
        int discountPercent = Convert.ToInt32(Console.ReadLine());
        
        int discountAmount = (courseFee * discountPercent) / 100;
        int finalFee = courseFee - discountAmount;
        
        Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {finalFee}");
    }
}
