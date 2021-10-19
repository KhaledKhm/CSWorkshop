using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider:Concept
    {
        private string confirmPassword;

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
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public string UserName { get; set; }
        private string password;

        public string Password
        {
            get { return password; }
            set { 
                if(value.Length>20 || value.Length < 5){
                    System.Console.WriteLine("Verifier votre mdp");
                }else
                {
                    password = value;
                }   
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

    }
}
