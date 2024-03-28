using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask14
{
	internal class Product
	{
		public string Id;
		public string BrandName;
		public string Model;
		public int Price;
		public int Cost;
		public int Income;
		public int Count;
		public Product(string id, string brandname, string model, int price, int cost, int count)
		{
			Id = id;
			BrandName = brandname;
			Model = model;
			Price = price;
			Cost = cost;
			Count = count;
			Sale();
		}
		public void GetInfo()
		{
			Console.WriteLine($"Id:{Id},BrandName:{BrandName},Model:{Model},Price:{Price},Cost:{Cost},Count:{Count},Income:{Income}");
			
		}
		public void Sale()
		{
			if (Count > 0)
			{
				Price = Price - Cost;
				Income += Price;
				Income *= Count;
				Count--;
			}
			else
			{
				Income = 0;
			}
		}

	}
}
