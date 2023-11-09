using System.Xml.Linq;
using zadanie2_Molotovs;
Random rnd = new Random();


string print(string txt)
{
    while (true)
    {
        Console.WriteLine(txt);
        return Console.ReadLine();
    }
    
}

bool stop = true;


Order order = new Order(rnd.Next(100000,999999));
while (stop)
{
    string Name = print("Введите навзание бургера");
    decimal basePrice = Convert.ToDecimal(print("Введите цену"));
    string ImagePath = print("Введите ссылку для картинки");
    Burger burger = new Burger(basePrice,Name, ImagePath);
    bool opt = Convert.ToBoolean(print("Вы ходите добавить доп ингридиенты для бургера? (true/false)"));
    while (opt)
    {
        string nameOpt = print("Введите название опции");
        decimal priceOpt = Convert.ToDecimal(print("Введите цену"));
        opt = Convert.ToBoolean(print("Вы ходите добавить доп ингридиенты для бургера? (true/false)"));
        Option option = new Option(nameOpt, priceOpt);
        burger.AddOption(option);
    }

    burger._basePrice = burger.GetPrice();
    order.AppProduct(burger);
    burger.ClearOptions();
    stop = Convert.ToBoolean(print("Вы ходите добавить доп еще бургер? (true/false)"));
}
stop = true;

while (stop)
{
    string Name = print("Введите навзание напитка");
    decimal basePrice = Convert.ToDecimal(print("Введите цену"));
    string ImagePath = print("Введите ссылку для картинки");
    int volume= Convert.ToInt32(print("Введите обьем напитка"));
    bool IsBittled = Convert.ToBoolean(print("Напиток будет в таре? (true/false)"));
    Drink drink = new Drink(basePrice, Name, ImagePath, volume, IsBittled);

    drink._basePrice = drink.GetPrice();
    order.AppProduct(drink);
    stop = Convert.ToBoolean(print("Вы ходите добавить доп еще напиток? (true/false)"));
}
Console.WriteLine("Ваш заказ:");
Console.WriteLine(order.GetCheck());
Console.ReadLine();