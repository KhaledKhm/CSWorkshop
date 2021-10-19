using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemical:Product
    {
        public string City { get; set; }
        public string LabName { get; set; }
        public string StreetAddress{ get; set; }

        //instead of super like java
        public override void GetDetails()
        {
            base.GetDetails();
            System.Console.WriteLine("LabName: " + LabName);
        }

        public override string GetMyType()
        {
            return "My type: CHEMICAL";
        }
    }
}
