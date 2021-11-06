using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service
{
    class ManageProduct
    {
        IList<Product> Prods;
        public ManageProduct(IList<Product> prods) {
            this.Prods = prods;
        }

        public IEnumerable<Chemical> Get5Chemical(double price)
        {
            var query = from prod in Prods
                        where prod.Price > price && prod is Chemical
                        select prod;
            return (IEnumerable<Chemical>)query.Take(5);
            //return query.OfType<Chemical>.Take(5);
        }
        //pour eleminer les 2 premiers elements de la liste
        public IEnumerable<Product> GetProductPrice(double price)
        {
            var query = from prod in Prods
                        where prod.Price > price
                        select prod;
            return query.Skip(2);
            //return query.OfType<Chemical>.Take(5);
        }

        //returns the average
        public double GetAveragePrice()
        {
            var query = from prod in Prods
                        select prod.Price;
            return query.Average();
        }

        //retourner le produit qui a le plus max prix
        public Product GetMaxPrice()
        {
            var query1 = from prod in Prods
                        select prod.Price;
            var query2 = from prod in Prods 
                         where (prod.Price==query1.Max()) 
                         select prod;
            return query2.FirstOrDefault();
        }

        //retourner le nombre de product selon a city
        public int GetCountProduct(string city)
        {
            var query = from prod in Prods
                        where ((Chemical)prod).MyAddress.City==city
                        select prod;
            return query.Count();
           
        }

        //retourner la list des produits chemical ordonnees par city
        public IEnumerable<Product> GetChemicaCity()
        {
            var query = from prod in Prods
                        orderby ((Chemical)prod).MyAddress.City ascending
                        select prod;
            return query;

        }

        //retourner la list des produits chemical ordonnees par city
        public void GetChemicalGroupByCity()
        {
            var query = from prod in Prods
                        orderby ((Chemical)prod).MyAddress.City
                        group (Chemical)prod by ((Chemical)prod).MyAddress.City;
            foreach (var group in query)
            {
                Console.WriteLine(group.Key);
                foreach (var i in group)
                {
                    i.GetDetails();
                }
            }

        }
    }
}
