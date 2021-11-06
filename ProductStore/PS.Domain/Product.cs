using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Product:Concept
    {
        [Display(Name="Production Date"),DataType(DataType.DateTime)] //u could put them each one by itself 
        public DateTime DateProd { get; set; } 
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Name is required"),StringLength(25,ErrorMessage ="Must be less than 25 characters"),MaxLength(50)] //u could put them each one by itself
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public int ProductId { get; set; }
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
        public string Image { get; set; }
        [ForeignKey("MyCategory")] //optional since the same name CategoryId is in Category.cs, if you want to name it something else you must add the annotation
        public int? CategoryId { get; set; }
        //[ForeignKey("CategoryFK")]
        public Category  MyCategory { get; set; }
        public IList<Provider> Providers { get; set; }
        public IList<Facture> Factures  { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Name: " + Name);
        }
        public virtual string GetMyType()
        {
            return "My type: UNKNOWN" ;
        }
    }
}
