using System;
using System.Collections.Generic;
using System.Linq;
using AdventureWorksLib;
using PHydrate;
using PHydrate.Core;

namespace PHydrateSpecificationDemo
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

            ISpecification<Product> specification = new ProductNumberSpecification("FR-R92B-58");

            Product product = session.Get(specification).FirstOrDefault();

            Console.WriteLine(product.ToString());

            specification = new ProductNameSpecification("Road%");

            IEnumerable<Product> products = session.Get(specification);

            foreach (Product p in products)
                Console.WriteLine(p.ToString());

            specification = new ColorSpecification("Red");

            products = session.Get(specification);

            foreach (Product p in products)
                Console.WriteLine(p.ToString());

            specification = new CombinedSpecification("Road%", "Red");

            products = session.Get(specification);

            foreach (Product p in products)
                Console.WriteLine(p.ToString());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
