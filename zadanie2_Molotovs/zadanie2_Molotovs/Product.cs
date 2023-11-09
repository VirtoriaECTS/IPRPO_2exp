using System;
namespace zadanie2_Molotovs
{
	abstract public class Product
	{
		private decimal basePrice;
		public string Name;
		public string ImagePath;

		public decimal _basePrice
		{
			get
			{
				return basePrice;
			}
			set
			{
				basePrice = value;
			}
		}

		public Product(decimal basePrice, string Name, string ImagePath)
		{
			this.basePrice = basePrice;
			this.Name = Name;
			this.ImagePath = ImagePath;
		}
		abstract public decimal GetPrice();

		
	}
}

