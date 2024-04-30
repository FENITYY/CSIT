using System;

class AccountTest{
    static void Main(){
        Account myAccount = new Account();
        Console.WriteLine($"Initial name is: {myAccount.GetName()}");
        
        Console.Write("Enter the name: ");
        string theName = Console.ReadLine(); 
        myAccount.SetName(theName);
        
        Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
    }
}