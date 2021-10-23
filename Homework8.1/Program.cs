using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Net.Sockets;

namespace homework_1
{
    class Program
    {
        static void Main()
        {
           

            check_del buble_check = Product.buble_check_by_days;
            List<Product> Produts_lt = new List<Product>();         
            Product temp1 = new Product("Milk", 35.90, 150, "25", "13.07.2021");
            Produts_lt.Add(temp1);
            Product temp2 = new Product("Meat", 35.90, 150, "3", "15.07.2021");
            Produts_lt.Add(temp2);
            Product temp3 = new Product("Bread", 35.90, 150, "30", "15.07.2021");
            Produts_lt.Add(temp3);
            Product[] Products_arr = new Product[Produts_lt.Count];


            for (int i = 0; i < Products_arr.Length; i++)
            {
                Console.WriteLine(i);
                Products_arr[i] = Produts_lt[i];
            }
            Sort_class.Sort(Products_arr, buble_check);

            for (int i = 0; i < Products_arr.Length; i++)
                Console.WriteLine(Products_arr[i].ToString());


            check_del buble_check_weight = Product.buble_check_by_weight;
            Sort_class.Sort(Products_arr, buble_check);

            for (int i = 0; i < Products_arr.Length; i++)
                Console.WriteLine(Products_arr[i].ToString());



        }
    }
}
