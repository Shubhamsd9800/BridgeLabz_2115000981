using System;

static class FeeCalculator
{
    public static void CalculateFee()
    {
        int fee = 125000;
        int discountPercent = 10;

        int discountAmount = (fee * discountPercent) / 100;
        int finalFee = fee - discountAmount;
		
        Console.WriteLine($"The discount amount is INR {discountAmount:F2} and final discounted fee is INR {finalFee:F2}");
    }
}
