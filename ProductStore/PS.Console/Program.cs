using PS.Data;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Hello World!");
            //Product Prod1 = new Product
            //{
            //    Name = "Product1",
            //    Price=5

            //};
            //Product Prod2 = new Product
            //{
            //    Name = "Product2",
            //    Price=5
            //};
            //Provider P1 = new Provider
            //{
            //    UserName = "Provider1",
            //    Password = "1234567",
            //    ConfirmPassword = "1234567",
            //    Email = "khmthe@gmail.com",
            //    IsApproved = false,
            //    Products = new List<Product>() { Prod1 }
            //};

            //Prod1.GetDetails("Name", "Prod1");

            //System.Console.WriteLine("#########################CUT##################################");
            //P1.GetDetails();
            ////System.Console.WriteLine(P1.Login("Provider1", "1234567"));
            ////System.Console.WriteLine(P1.Login("Provider1", "1234567","khmthe@gmail.com"));
            //System.Console.WriteLine(Prod1.GetMyType());
            //Chemical ch1 = new Chemical();
            //Biological bio1 = new Biological();
            //System.Console.WriteLine(ch1.GetMyType());
            //System.Console.WriteLine(bio1.GetMyType());

            //Provider.SetIsApproved(P1);
            //System.Console.WriteLine("Methode a");
            //P1.GetDetails();
            //bool IsApproved = P1.IsApproved;
            //Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, ref IsApproved);
            //System.Console.WriteLine("Methode b");
            //P1.IsApproved = IsApproved;
            //P1.GetDetails();

            //========================================================================================

            //Scénario de test
            //Categories / Providers    CAT1              CAT2        CAT3        NULL
            //PROV1                     PROD1, PROD2                  PROD3
            //PROV2                     PROD1             PROD5
            //PROV3                     PROD1                                     PROD4
            //PROV4                                                   PROD6       PROD4
            //PROV5                                                   PROD6       PROD4


            //Category cat1 = new Category() { Name = "CAT1" };
            //Category cat2 = new Category() { Name = "CAT2" };
            //Category cat3 = new Category() { Name = "CAT3" };
            //Provider prov1 = new Provider() { UserName = "PROV1" };
            //Provider prov2 = new Provider() { UserName = "PROV2" };
            //Provider prov3 = new Provider() { UserName = "PROV3" };
            //Provider prov4 = new Provider() { UserName = "PROV4" };
            //Provider prov5 = new Provider() { UserName = "PROV5" };
            //Product prod1 = new Product() { Name = "PROD1", MyCategory = cat1, Providers = new List<Provider>() { prov1, prov2, prov3 } };
            //Product prod2 = new Product() { Name = "PROD2", MyCategory = cat1, Providers = new List<Provider>() { prov1 } };
            //Product prod3 = new Product() { Name = "PROD3", MyCategory = cat3, Providers = new List<Provider>() { prov1 } };
            //Product prod4 = new Product() { Name = "PROD4", Providers = new List<Provider>() { prov3, prov4, prov5 } };
            //Product prod5 = new Product() { Name = "PROD5", MyCategory = cat2, Providers = new List<Provider>() { } };
            //Product prod6 = new Product() { Name = "PROD6", MyCategory = cat3, Providers = new List<Provider>() { prov4, prov5 } };
            //cat1.Products = new List<Product>() { prod1, prod2 };
            //cat2.Products = new List<Product>() { prod5 };
            //cat3.Products = new List<Product>() { prod3, prod6 };
            //prov1.Products = new List<Product>() { prod1, prod2, prod3 };
            //prov2.Products = new List<Product>() { prod1, prod5 };
            //prov3.Products = new List<Product>() { prod1 };
            //prov4.Products = new List<Product>() { prod4, prod6 };
            //prov5.Products = new List<Product>() { prod4, prod6 };


            //System.Console.WriteLine("Détails des providers");
            //prov1.GetDetails();
            //prov2.GetDetails();
            //prov3.GetDetails();

            /*
            Product Prod1 = new Product
            {
                Name = "Product1",
                DateProd = DateTime.Now,
                Price = 5
            };


            Product Prod2 = new Product
            {
                Name = "Product2",
                DateProd = DateTime.Now,
                Price = 5
            };


            Product Prod3 = new Product
            {
                Name = "Product3",
                DateProd = DateTime.Now,
                Price = 5
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

            Provider P2 = new Provider
            {
                UserName = "Provider2",
                Password = "1234567",
                ConfirmPassword = "1234567",
                Email = "khmthe@gmail.com",
                IsApproved = false,
                Products = new List<Product>() { Prod2 }
            };

            Provider P3 = new Provider
            {
                UserName = "Provider3",
                Password = "1234567",
                ConfirmPassword = "1234567",
                Email = "khmthe@gmail.com",
                IsApproved = false,
                Products = new List<Product>() { Prod3 }
            };*/
            /*##################################TP3###############################*/
            //using (var context = new PSContext())
            //{
            //    //Create
            //    System.Console.WriteLine("Create");
            //    //Instancier un object PRoduct

            //    Product P = new Product { Name = "Prod1", DateProd=DateTime.Now };
            //    //Ajouter l'objet au DBSET
            //    context.Products.Add(P);
            //    //Persister les donnees
            //    context.SaveChanges();

            /*       System.Console.WriteLine();

               //Read Last
               System.Console.WriteLine("Read Last");
               var prod = context.Products.OrderBy(P => P.ProductId);
               prod.name
              */
            using (var context = new PSContext())
            {
                //Create
                System.Console.WriteLine("Create");
                //Instancier un objet Product
                Product P = new Product
                {
                    Name = "Prod1",
                    DateProd = DateTime.Now
                };
                //Ajouter l'objet au DBSET
                context.Products.Add(P);
                //Persister les données
                context.SaveChanges();



                //Read All
                System.Console.WriteLine("Read All");
                foreach (Product p in context.Products)
                {
                    System.Console.WriteLine(p.ProductId + " " + p.Name);
                }


                //Read Last
                System.Console.WriteLine("Read Last");
                var prod = context.Products.OrderBy(p => p.ProductId)
                    .Last();
                System.Console.WriteLine(prod.ProductId + " " + prod.Name);


                // Update
                //System.Console.WriteLine("Update");
                //prod.Name = "newName";
                //context.SaveChanges();
                //System.Console.WriteLine(prod.ProductId + " " + prod.Name);


                // Delete
                //System.Console.WriteLine("Delete the product");
                //context.Remove(prod);
                //context.SaveChanges();
            }
        }
        }
    }

