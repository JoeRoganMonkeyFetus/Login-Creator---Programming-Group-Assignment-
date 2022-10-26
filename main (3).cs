using System;
class Program {
  public static void Main (string[] args) {
   
    Console.WriteLine("Enter username");
     String loginUser = Console.ReadLine();
        string username = "Grade 10";
        
    Console.WriteLine("Enter password");
        String loginPass = Console.ReadLine();
    string password = "12345";
              
        if (loginUser != username || loginPass != password) 
        {
         Console.WriteLine("Access denied");
        }
        else {
          Console.WriteLine("Access granted, Welcome Sachdeva");
        }
  }
}