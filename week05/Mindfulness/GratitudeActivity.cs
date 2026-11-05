using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity() : base("Gratitude Activity",
        "This activity will help you focus on gratitude by thinking of three things you are thankful for today. Gratitude brings peace and joy.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Think of 3 things you are grateful for today.");
        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Grateful #{i}: ");
            Console.ReadLine();
            ShowSpinner(2);
        }
        Console.WriteLine("Thank you for practicing gratitude!");
        DisplayEndingMessage();
    }
}