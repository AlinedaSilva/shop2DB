using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop2DB
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUpDatabase();
        }
        private static void SetUpDatabase()
        {
            Customer cb = new Customer() { CName = "CustomerB", CAddress = "Street 13", Phone = "087222222" };
            Customer cc = new Customer() { CName = "CustomerC", CAddress = "Street 14", Phone = "087333333" };
            Customer cd = new Customer() { CName = "CustomerD", CAddress = "Street 15", Phone = "087444444" };
            Customer ce = new Customer() { CName = "CustomerE", CAddress = "Street 16", Phone = "087555555" };
            Customer cf = new Customer() { CName = "CustomerF", CAddress = "Street 17", Phone = "087666666" };
            Customer cg = new Customer() { CName = "CustomerG", CAddress = "Street 18", Phone = "087777777" };
            Customer ch = new Customer() { CName = "CustomerH", CAddress = "Street 19", Phone = "087888888" };
            Customer ci = new Customer() { CName = "CustomerI", CAddress = "Street 20", Phone = "087999999" };
            Customer cj = new Customer() { CName = "CustomerJ", CAddress = "Street 21", Phone = "087000000" };

            Shop2Context db = new Shop2Context();

            db.Customers.Add(cb);
            db.Customers.Add(cd);
            db.Customers.Add(ce);
            db.Customers.Add(cf);
            db.Customers.Add(cg);
            db.Customers.Add(ch);
            db.Customers.Add(ci);
            db.Customers.Add(cj);
            db.SaveChanges();

            {
                Product pa = new Product { Pname = "ProductA", Price = 10 };
                Product pb = new Product { Pname = "ProductB", Price = 20 };
                Product pc = new Product { Pname = "ProductC", Price = 30 };
                Product pd = new Product { Pname = "ProductD", Price = 40 };
                Product pe = new Product { Pname = "ProductE", Price = 50 };
                Product pf = new Product { Pname = "ProductF", Price = 60 };
                Product pg = new Product { Pname = "ProductG", Price = 70 };
                Product ph = new Product { Pname = "ProductH", Price = 80 };
                Product pi = new Product { Pname = "ProductI", Price = 90 };
                Product pj = new Product { Pname = "ProductG", Price = 100 };

                Shop2Context db1 = new Shop2Context();

                db1.Products.Add(pa);
                db1.Products.Add(pb);
                db1.Products.Add(pc);
                db1.Products.Add(pd);
                db1.Products.Add(pe);
                db1.Products.Add(pf);
                db1.Products.Add(pg);
                db1.Products.Add(pi);
                db1.Products.Add(pj);
                db1.SaveChanges();
                {
                    Order o1 = new Order { CustomerID = 1, ProductID = 1, Qty = 1 };
                    Order o2 = new Order { CustomerID = 2, ProductID = 2, Qty = 1 };
                    Order o3 = new Order { CustomerID = 3, ProductID = 3, Qty = 5 };
                    Order o4 = new Order { CustomerID = 4, ProductID = 4, Qty = 10 };
                    Order o5 = new Order { CustomerID = 1, ProductID = 5, Qty = 189 };
                    Order o6 = new Order { CustomerID = 3, ProductID = 5, Qty = 44 };
                    Order o7 = new Order { CustomerID = 8, ProductID = 4, Qty = 34 };
                    Order o8 = new Order { CustomerID = 2, ProductID = 3, Qty = 78 };
                    Order o9 = new Order { CustomerID = 1, ProductID = 4, Qty = 9 };
                    Order o10 = new Order { CustomerID = 1, ProductID = 9, Qty = 19 };

                    Shop2Context db2 = new Shop2Context();

                    db2.Orders.Add(o1);
                    db2.Orders.Add(o2);
                    db2.Orders.Add(o2);
                    db2.Orders.Add(o3);
                    db2.Orders.Add(o4);
                    db2.Orders.Add(o5);
                    db2.Orders.Add(o6);
                    db2.Orders.Add(o7);
                    db2.Orders.Add(o8);
                    db2.Orders.Add(o9);
                    db2.Orders.Add(o10);
                    db2.SaveChanges();
                }
            }
        }
    }
}
