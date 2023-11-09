using System;
namespace zadanie2_Molotovs
{
	public class Drink: Product
	{
        public int Volume;
        public bool IsBottled;

        public Drink(decimal basePrice, string Name, string ImagePath, int Volume, bool IsBottled)
            : base(basePrice, Name, ImagePath)
        {
            this.Volume = Volume;
            this.IsBottled = IsBottled;
        }

        public override decimal GetPrice()
        {
            if (IsBottled)
            {
                return _basePrice + 25;
            }
            else return _basePrice;
        }
    }
}

