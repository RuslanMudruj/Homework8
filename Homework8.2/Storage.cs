using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace homework_1
{
    class Storage
    {
        int n;
        public List<Product> many_product;
        public Product this[int index]
        {
            set
            {
                many_product[index] = value;
            }
            get
            {
                if (index < many_product.Count)
                    return many_product[index];
                else
                    throw new Exception("index is begger than many product's lenght");
            }

        }


        public Storage()
        {
            this.many_product = new List<Product>();
        }
        public Storage(List<Product> el)
        {
            this.many_product  = new List<Product>();
            this.many_product.AddRange(el);
        }




        public void date_delete()
        {
            DateTime dt = DateTime.Now;
            string[] date = dt.ToString("d").Split('.');
            
            for(int i = 0;i< many_product.Count; i++)
            {
                if (many_product[i].Type == "Milk")
                {
                    string[] product_date = many_product[i].Date.Split('.');
                }
            }
        }

        public void out_file()
        {

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Ruslanchik\source\repos\Homework_№3\out.txt", false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < many_product.Count; i++)
                {
                    sw.WriteLine(String.Format("Product {0}\tPrice {1}\tType {2}\tDate {3} \n", many_product[i].Name, many_product[i].Price, many_product[i].Type));
                }


            }
        }
        public void in_file()
        {

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Ruslanchik\source\repos\Homework_№3\out.txt", false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < many_product.Count; i++)
                {
                    sw.WriteLine(String.Format("Product {0}\tPrice {1}\tType {2}\tDate {3} \n", many_product[i].Name, many_product[i].Price, many_product[i].Type));


                }
            }
        }








        // Methods------------------------------------------------------------

    

        public void dialog_method()
        {
            for (int i = 0; i < 3; i++)
            {
                string namee = Console.ReadLine();
                many_product[i].Name = namee;
                Console.WriteLine("Pleas enter a price");
                int pric = int.Parse(Console.ReadLine());
                many_product[i].Price = pric;
                Console.WriteLine("Pleas enter a weight");
                int weig = int.Parse(Console.ReadLine());
                many_product[i].Weight = weig;
            }

        }


        public void init_method()
        {
            many_product[0].Name = "Meat";
            many_product[0].Price = 50;
            many_product[0].Weight = 100;

            many_product[1].Name = "Milk";
            many_product[1].Price = 30;
            many_product[1].Weight = 1;


            many_product[2].Name = "Eggs";
            many_product[2].Price = 10;
            many_product[2].Weight = 30;

        }





        public void druk_product()
        {
            for (int i = 0; i < 3; i++)
                Console.WriteLine("Information about Product: " + '\n' + "Name: " + many_product[i].Name + '\n' + "Price: " + many_product[i].Price + "\n Weight: " + many_product[i].Weight);

        }






        public void meat_check()
        {
           
            for (int i = 0; i < 3; i++)
            {
                if (many_product[i].Name == "Meat")
                {
                    Console.WriteLine("Information about Meat Product: " + '\n' + "Name: " + many_product[i].Name + '\n' + "Price: " + many_product[i].Price + "\n Weight: " + many_product[i].Weight);


                }
            }
        }

        public void store_changeprice(int persent)
        {
            for (int i = 0; i < 3; i++)
            {
                many_product[i].change_price(persent);
            }

        }


        //Methods for TASK 8.2

        public static Storage mutual_products(Storage a, Storage b)
        {
            Storage mutal_products = new Storage();
            foreach (var prod in a.many_product)
                if (b.many_product.Contains(prod))// return false, but in list is a mutual product
                {
                    mutal_products.many_product.Add(prod);
                }
            return mutal_products;
        }
        public static Storage different_first_storage_products(Storage a, Storage b)
        {
            Storage mutal_products = new Storage();
            foreach(var prod in a.many_product)
                if (!b.many_product.Contains(prod))
                {
                    mutal_products.many_product.Add(prod);
                }
            return mutal_products;
        }
        protected static List<Product> Check_prod(List<Product> a, List<Product> b)
        {
            List<Product> product_list = new List<Product>();
            foreach(var prod in b)
                if (!a.Contains(prod))
                {
                    product_list.Add(prod);
                }
            return product_list;
        }

        public static Storage different_products(Storage a, Storage b)
        {
            Storage mutal_products = new Storage();
            mutal_products.many_product.AddRange(Check_prod(a.many_product, b.many_product));
            mutal_products.many_product.AddRange(Check_prod(b.many_product, a.many_product));

            return mutal_products;
        }
    }
}


