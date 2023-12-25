
try
{
    Console.Write("Введите название книги: ");
    string? name = Console.ReadLine();

    Console.Write("Введите количество страниц: ");
    int sheets = int.Parse(Console.ReadLine());

    Console.Write("Введите стоимость книги: ");
    int price = int.Parse(Console.ReadLine());

    Library book = new Library(name, sheets, price);
    Console.WriteLine(book.FullInfo(name));
}

catch (Exception ex)
{ Console.WriteLine(ex.Message); }
class Book
{
    private string? name;
    private int sheets;
    private decimal price;



    public string? Name { get { return name; } set { if (value != null) name = value; } }
    public decimal Price
    {
        get { return price; }
        set { if (value >= 0) price = value; }
    }

    public int Sheets
    {
        get { return sheets; }
        set { if (value >= 0) sheets = value; }
    }

    public string GetAverage(int Sheets, decimal Price)
    {
        return $"Средняя стоимость страницы: {(GetPrice(Name) / Sheets):F2}.";
    }

    public string Info()
    {
        return $"Книга: {Name}; стоимость: {GetPrice(Name)}; средняя стоимость страницы: {GetAverage(Sheets, Price)}";
    }
    public decimal GetPrice(string name)
    {
        if (Name.IndexOf("Программирование") == 0) return price * 2;
        else return price;
    }


    public Book(string? name, int sheets, decimal price)
    {
        this.name = name;
        this.Sheets = sheets;
        this.Price = price;

    }
}




class Library : Book
{

    

    public string? Name { get { return base.Name; } set { if (value != null) base.Name = value; } }

    public int Sheets
    {
        get { return base.Sheets; }
        set { if (value >= 0) base.Sheets = value; }
    }

    public decimal Price
    {
        get { return base.Price; }
        set { if (value >= 0) base.Price = value; }
    }

    public string Discount(decimal Price) // Так как не было в задании указано критериев скидки, я сделал её произвольно.
    {
        Random random = new Random();
        int a = random.Next(0, 21);
        return $"Стоимость книги {Name} с учётом скидки ({a}%) составляет {(Price - (Price * a / 100)):F2}.";
    }

    public string FullInfo(string? Name)
    {
        return $"Название книги: {Name}, количество страниц: {Sheets}, стоимость без учёта скидки: {Price}." + Discount(Price);
    }
    public Library(string? name, int sheets, decimal price) : base(name, sheets, price)
    {
        this.Name = base.Name;
        this.Sheets = base.Sheets;
        this.Price = base.Price;
    }
}
