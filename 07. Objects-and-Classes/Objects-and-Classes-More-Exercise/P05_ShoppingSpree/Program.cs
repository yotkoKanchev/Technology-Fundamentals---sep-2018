using System;
using System.Collections.Generic;

namespace P05_ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
            string[] productTokens = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < personTokens.Length; i++)
            {
                string[] tokens = personTokens[i].Split("=");
                Person person = new Person(tokens);
                people.Add(person);
            }

            for (int i = 0; i < productTokens.Length; i++)
            {
                string[] tokens = productTokens[i].Split("=");
                Product product = new Product(tokens);
                products.Add(product);
            }

            string buyerInfo = Console.ReadLine();

            while (buyerInfo != "END")
            {
                string[] tokens = buyerInfo.Split();
                string personBuying = tokens[0];
                string buyingProduct = tokens[1];

                people.Find(x => x.PersonName == personBuying).BuyProduct(products.Find(x => x.ProductName == buyingProduct));

                buyerInfo = Console.ReadLine();
            }

            foreach (var member in people)
            {
                if (member.BagOfProducts.Count > 0 )
                {
                    Console.WriteLine($"{member.PersonName} - {string.Join(", ", member.BagOfProducts)}");
                }
                else
                {
                    Console.WriteLine($"{member.PersonName} - Nothing bought");
                }
            }
        }

        class Person
        {
            public Person(string[] tokens)
            {
                this.PersonName = tokens[0];
                this.Money = decimal.Parse(tokens[1]);
            }
            public string PersonName { get; set; }
            public decimal Money { get; set; }
            public List<string> BagOfProducts { get; set; } = new List<string>();

            public void BuyProduct(Product productToBuy)
            {
                if (this.Money >= productToBuy.Cost)
                {
                    this.Money -= productToBuy.Cost;
                    BagOfProducts.Add(productToBuy.ProductName);
                    Console.WriteLine($"{this.PersonName} bought {productToBuy.ProductName}");
                }
                else
                {
                    Console.WriteLine($"{this.PersonName} can't afford {productToBuy.ProductName}");
                }
            }
        }

        class Product
        {
            public Product(string[] productsTokens)
            {
                this.ProductName = productsTokens[0];
                this.Cost = decimal.Parse(productsTokens[1]);
            }
            public string ProductName { get; set; }
            public decimal Cost { get; set; }
        }
    }
}
