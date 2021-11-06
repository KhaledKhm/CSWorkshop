using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Facture
    {
     //   [ForeignKey("Client")] or u can use this instead of the other or FactureConfiguration
        public int ClientFK { get; set; }
     //   [ForeignKey("Product")]
        public int ProductFK { get; set; }
        public DateTime DateAchat { get; set; }
        public int Prix { get; set; }

       // [ForeignKey("ClientFK")] //can use this instead of FactureConfiguration
        public Client Client { get; set; }

     //   [ForeignKey("ProductFK")]
        public Product Product { get; set; }
    }
}
