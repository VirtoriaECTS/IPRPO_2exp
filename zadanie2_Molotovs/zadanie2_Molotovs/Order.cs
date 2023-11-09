using System;
namespace zadanie2_Molotovs
{
	public class Order
		
	{
		//класс для оформления заказа
		private List<Product> products = new List<Product>(); //товар (название и цена)
		int Number; //номер заказа
		DateTime OrderTime; //время

		public Order(int Number)
		{
			this.Number = Number;
			OrderTime = DateTime.Now;
		}
		//номер, дата и время, сам заказ

		public void AppProduct(Product product)
		{
			products.Add(product);
		}
		public void Clear()
		{
			products.Clear();
		}
		public decimal TotalPrice()
		{
            decimal allPrice = 0;
            for (int i = 0; i < products.Count; i++)
            {
                allPrice += products[i]._basePrice;
            }
            if (allPrice == 0)
            {
                return 0;
            }
            else return allPrice;
        }
		public string GetCheck()
		{
			string check = $"Номер {Number}\nДата: {OrderTime}\n";
			for(int i = 0; i < products.Count; i++)
			{
				check += $"Наименование {products[i].Name} Стоимость: {products[i]._basePrice}\n";
			}
			check += $"\n {TotalPrice().ToString()}";
			return check;
		}

	}
}

