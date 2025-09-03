namespace Banking.handlers;

public static  class AccountListener
{

    public static void AccountBlocked()
    {
        Console.WriteLine($"AccountBlocked:");
    }  
    public static void SendEmail()
    {
        Console.WriteLine($"SendEmail:");
    }  
}