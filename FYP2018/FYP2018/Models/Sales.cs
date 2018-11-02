using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P03.Models
{
    public class Sales
    {
        public static List<Order> GetLocalOrders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order() { ProductId = "ST0001", CatId = "A", Price = 12.50, Qty = 5 });
            orders.Add(new Order() { ProductId = "ST0032", CatId = "B", Price = 11.60, Qty = 7 });
            orders.Add(new Order() { ProductId = "CU0686", CatId = "C", Price = 10.70, Qty = 3 });
            orders.Add(new Order() { ProductId = "CU0773", CatId = "A", Price = 22.90, Qty = 9 });
            orders.Add(new Order() { ProductId = "PP1094", CatId = "B", Price = 3.10, Qty = 2 });
            orders.Add(new Order() { ProductId = "GU0773", CatId = "C", Price = 22.90, Qty = 5 });
            orders.Add(new Order() { ProductId = "JU0773", CatId = "A", Price = 22.90, Qty = 5 });

            return orders;
        }

        public static List<Order> GetOverseasOrders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order() { ProductId = "TS0010", CatId = "A", Price = 25.50, Qty = 15 });
            orders.Add(new Order() { ProductId = "UC0866", CatId = "C", Price = 20.50, Qty = 9 });
            orders.Add(new Order() { ProductId = "PQ0194", CatId = "B", Price = 6.50, Qty = 6 });
            orders.Add(new Order() { ProductId = "UJ3770", CatId = "A", Price = 44.50, Qty = 15 });

            return orders;
        }

        public static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category() { CatId="A", CatName = "Health Products"},
                new Category(){CatId="B", CatName= "Toiletries"},
                new Category() {CatId="C", CatName="Kitchen Appliance"}
            };

            return categories;
        }

    }
}