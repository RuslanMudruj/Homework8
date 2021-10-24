using System;
using System.Collections.Generic;
using System.Text;

namespace homework_1
{

    delegate int check_del(Product a, Product b);
    class Sort_class
    {
		public static void Sort(Product[] prod_arr, check_del buble_check)
        {
			for (int i = 1; i < prod_arr.Length; ++i)
			{
				for (int r = 0; r < prod_arr.Length - i; r++)
				{
					if (buble_check(prod_arr[r], prod_arr[r+1])==1)
					{
						
						Product temp = prod_arr[r];
						prod_arr[r] = prod_arr[r + 1];
						prod_arr[r + 1] = temp;
					}
				}
			}
		}



    }
}
