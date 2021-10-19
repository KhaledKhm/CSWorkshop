using PS.Domain;
using System;
using System.Collections.Generic;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Hello World!");
            Product Prod1 = new Product
            {
                Name = "Product1"
            };
            Provider P1 = new Provider
            {
                UserName = "Provider1",
                Password = "1234567",
                ConfirmPassword = "1234567",
                Email = "khmthe@gmail.com",
                IsApproved = false,
                Products = new List<Product>() { Prod1 }
            };
            
            P1.GetDetails();
            //System.Console.WriteLine(P1.Login("Provider1", "1234567"));
            //System.Console.WriteLine(P1.Login("Provider1", "1234567","khmthe@gmail.com"));
            System.Console.WriteLine(Prod1.GetMyType());
            Chemical ch1 = new Chemical();
            Biological bio1 = new Biological();
            System.Console.WriteLine(ch1.GetMyType());
            System.Console.WriteLine(bio1.GetMyType());
            //Provider.SetIsApproved(P1);
            //System.Console.WriteLine("Methode a");
            //P1.GetDetails();
            //bool IsApproved = P1.IsApproved;
            //Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, ref IsApproved);
            //System.Console.WriteLine("Methode b");
            //P1.IsApproved = IsApproved;
            //P1.GetDetails();

        }
    }
}
