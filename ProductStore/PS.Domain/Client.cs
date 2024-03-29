﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PS.Domain
{
    public class Client
    {
        [Key]
        public int CIN { get; set; }
        public DateTime DateNaissance { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Mail { get; set; }
        public virtual IList<Facture> Factures { get; set; }

    }
}
