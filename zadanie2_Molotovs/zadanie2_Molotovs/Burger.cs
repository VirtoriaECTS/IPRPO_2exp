using System;
namespace zadanie2_Molotovs
{
	public class Burger : Product
	{
       //доп оптиции для бургера
       private List<Option> options = new List<Option>();


        public Burger(decimal basePrice, string Name, string ImagePath)
            : base(basePrice, Name, ImagePath)
        {

        }

        public override decimal GetPrice()
        {
            decimal allPriceOption = 0;
            for(int i = 0; i < options.Count; i++)
            {
                allPriceOption += options[i].Price;
            }
            if (allPriceOption == 0)
            {
                return _basePrice;
            }
            else return _basePrice + allPriceOption;
        }
        //добавить
        public  void AddOption(Option option)
        {
            options.Add(option);
        }
        public void ClearOptions()
        {
            options.Clear();
        }
    }
}

