using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service
{
    public class ManageProvider
    {
        public IList<Provider> Providers;
        public ManageProvider(IList<Provider> providers)
        {
            this.Providers = providers;
        }
        //public IList<Provider> GetFirstProviderByName(string name)
        public IList<Provider> GetProviderByName(string name)
//      public IEnnumerable<Provider> GetFirstProviderByName2(string name) to return query; only as query type instead of list

        {
            var query = from p in Providers where p.UserName == name select p;
                return query.ToList();
        }
        public Provider GetFirstProviderByName(string name)

        {
            var query = from p in Providers 
                        where p.UserName == name 
                        select p;
            return query.FirstOrDefault();
        }
        public Provider GetProviderById(int id) {
            var query = from p in Providers 
                        where p.Id == id 
                        select p;
            return query.SingleOrDefault();


        }
    }
}