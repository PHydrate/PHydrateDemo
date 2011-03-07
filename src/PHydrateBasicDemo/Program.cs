using System;
using System.Linq;
using AdventureWorksLib;
using PHydrate;
using PHydrate.Core;

namespace PHydrateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseService sqlServerDatabaseService = new SqlServerDatabaseService(
                @"Data Source=localhost\consulting;Initial Catalog=AdventureWorksLT2008;Integrated Security=SSPI");

            ISessionFactory sessionFactory =
                Fluently.Configure.Database(
                    sqlServerDatabaseService)
                    .BuildSessionFactory();

            ISession session = sessionFactory.GetSession();

            Product product = session.Get<Product>(x => x.ProductNumber == "FR-R92B-58").FirstOrDefault();

            Console.WriteLine(product.ToString());
        }
    }
}
