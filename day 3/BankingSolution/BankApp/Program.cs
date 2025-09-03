using Banking;
using Banking.handlers;

// public partial class Program
// {
//     static void Main(string[] args)
//     {
        Account acct1234 = new Account();
        acct1234.Balance = 1000;
        acct1234.Withdraw(200);
        acct1234.Deposit(500);
        acct1234.accountInfo += AccountListener.AccountBlocked;
        acct1234.accountInfo += AccountListener.SendEmail;
        Console.WriteLine($"Account 1234 balance: {acct1234.Balance}");

        //direct calling
        AccountListener.AccountBlocked();
        AccountListener.SendEmail();

        //indirect calling using delegate 
        // AccountOperation agent = new AccountOperation(AccountListener.AccountBlocked);
        // agent += AccountListener.AccountBlocked;
        // agent += AccountListener.SendEmail;
        // agent();
//     } 
// }