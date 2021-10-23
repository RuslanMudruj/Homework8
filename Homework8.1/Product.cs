using System;
using System.Collections.Generic;
using System.Text;

namespace homework_1
{
    class Product
    {
        protected string name;
        public string Name
        {
            set
            {
                name = value;

            }
            get
            {
                return name;
            }
        }



        protected string type;
        public string Type
        {
            set
            {
                type = value;

            }
            get
            {
                return type;
            }

        }

        protected double price;
        public double Price
        {
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                    throw new Exception("price is incorrect");

            }
            get
            {
                return price;
            }
        }

        protected int weight;
        public int Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("weight is incorrect");

            }
            get
            {
                return weight;
            }
        }

        protected int days;
        public int Days
        {
            set
            {
                days = value;

            }
            get
            {
                return days;
            }

        }
        protected string date;
        public string Date
        {
            set
            {
                date = value;

            }
            get
            {
                return date;
            }

        }



      
        public Product()
        {

        }

        public Product(string in_name, double in_price, int in_weight,string in_days,string in_date)
        {
            this.name = in_name;
            if (in_price > 1)
            {
                this.price = in_price;
            
            }
            else
                throw new Exception("price is incorrect");

            if (in_weight > 1)
            {
                this.weight = in_weight;
            }
            else
                throw new Exception("weight is incorrect");
            
            if ((int.Parse(in_days) > 1) && (int.Parse(in_days) < 31)) 
            {
                this.days = int.Parse(in_days);
            }
            else
                throw new Exception("wa is incorrect");
            


            
                this.date = in_date;
        }


        public static int buble_check_by_days(Product a, Product b)
        {
            if (a.Days > b.Days)
                return 1;
            else
                return 0;
        }


        public static int buble_check_by_weight(Product a, Product b)
        {
            if (a.Weight > b.Weight)
                return 1;
            else
                return 0;
        }

    public virtual void change_price(double d_percents) 
        {
            
            this.price = this.price * (d_percents / 100);
        }
        public override string ToString()// перевантаження  метода ToString
        {
            return "Name: " + this.Name  + '\n' + "Price: " + this.Price + "Weight: " + this.Weight + "\n Days: " + this.Days ;

        }
        
        
        
        
        
        
        
         

    }
}
