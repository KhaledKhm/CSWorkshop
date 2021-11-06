using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Provider:Concept
    {
        private string confirmPassword;
        [Required(ErrorMessage ="You must confirm password"),DataType(DataType.Password),Compare("Password"),NotMapped]
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set {
                if (!value.Equals(Password)){
                    System.Console.WriteLine("Confirmer votre mdp correctement!");

                }
                else { confirmPassword=value; }
            }
        }

        public DateTime DateCreated { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Key] //to make it primary but if you name your variable Id it will automatically take it as a primary key
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public string UserName { get; set; }
        private string password;
        [DataType(DataType.Password),MinLength(8,ErrorMessage ="Password must be at least 8 characters"),Required(ErrorMessage ="You must type a password")]
        public string Password
        {
            get { return password; }
            set { /*
                if(value.Length>20 || value.Length < 5){
                    System.Console.WriteLine("Verifier votre mdp");
                }else
                {
                    password = value;
                }*/   
            }
        }

        public IList<Product> Products { get; set; }
        
        public override void GetDetails()
        {
            if (Products == null)
            {
                System.Console.WriteLine("List is empty");
            }
            else {
                foreach (Product p in Products)
                {
                    p.GetDetails();
                }
            }
            //System.Console.WriteLine("UserName: " + UserName + "Password " + Password + "ConfirmPassword: " + ConfirmPassword + "IsApproved: " + IsApproved "\n ");
        }
        public static void SetIsApproved(Provider P)
        {
            P.IsApproved = P.Password.CompareTo(P.ConfirmPassword)==0;

        }
        public static void SetIsApproved(string Password, string ConfirmPassword, ref bool IsApproved)
        {
            IsApproved = Password.CompareTo(ConfirmPassword) == 0;

        }
        //public bool Login(string UserName,string Password)
        //{
        //    return this.UserName == UserName && this.Password == Password;
        //}
        //public bool Login(string UserName, string Password, string Email)
        //{
        //    return this.UserName == UserName && this.Password == Password && this.Email==Email;
        //}
        public bool Login(string UserName, string Password, string Email=null)
        {
            if (Email == null)
            {
                return this.UserName == UserName && this.Password == Password && this.Email == Email;
            }
            else 
            {
                return this.UserName == UserName && this.Password == Password;
            }
        }
        public void GetProducts(string filterType, string filterValue)
        {
            if (this.Products != null)
            {
                switch (filterType)
                {
                    case "DateProd":
                        {
                            foreach(Product p in Products)
                            {
                                if (p.DateProd.Equals(DateTime.Parse(filterValue)))
                                {
                                    p.GetDetails();
                                }
                            }
                            break;
                        }
                    case "Name":
                        {
                            foreach(Product p in Products)
                            {
                                if (p.Name.Equals(filterValue))
                                {
                                    p.GetDetails();
                                }
                            }
                            break;
                        }
                    case "Prix":
                        {
                            foreach(Product p in Products)
                            {
                                if (p.Price == Double.Parse(filterValue))
                                {
                                    p.GetDetails();
                                }
                            }
                            break;
                        }
                    case "Category":
                        {
                            foreach (Product p in Products)
                            {
                                if (p.MyCategory.Name.Equals(filterValue))
                                {
                                    p.GetDetails();
                                }
                            }
                            break;
                        }
                    case "Description":
                        {
                            foreach (Product p in Products)
                            {
                                if (p.Description.Equals(filterValue))
                                {
                                    p.GetDetails();
                                }
                            }
                            break;
                        }
                }
            }
        }

    }
}
