//using System.Net.Cache;


//Person person = new Person("Vasya", 3432);








//class Person
//{
//    public string? Name { get; set; }
//    public int? Age { get; set; }
//    public Person(string? name, int age)
//    {
//        Name = name;
//        Age = age;

//    }
//    public override string ToString()
//    {

//        {
//            return $"Name: {Name}, age: {Age}";

//        }
//    }


//}

//class Employe : Person
//{

//    public string? Company { get; set; }

//    public Employe(string? name, int age, string company) : base(name, age)
//    {
//        Company = company;  
//    }
//}



//using System.Diagnostics;
//Console.WriteLine("Enter the frequency: ");
//double freq = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the ROM: ");
//double rom = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the name of a CPU: ");
//string processor = Console.ReadLine();

//Computer computer = new Computer(freq, rom, processor);
//Console.WriteLine(computer.Q(freq,rom));

//class Computer
//{
//    private string? processor;
//    public double Frequency { get; set; }
//    public double ROM{ get; set; }
//    public string Q(double frequency, double rom)
//    {
//        return $"{((0.5 * frequency) + rom)}";
//    }

//    public Computer(double frequency, double rom, string processor)
//    {

//        this.Frequency = frequency;
//        this.ROM = rom;
//        this.Processor = processor;
//    }

//    public string Processor
//    {  
//        get { return processor;}
//        set {if(value != null) 
//            processor = value;}
//    }

//}
//class P : Computer 
//{
//    public P(double frequency, double rom, string processor) : base(frequency, rom, processor)
//    {

//    }

//    public double Vin { get; set; }
//    public string Qp()
//    { return $"Q_p = {base.Q(Frequency, ROM) + 0.5 * ROM}"; }

//} class Company





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

catch(Exception ex)
{ Console.WriteLine(ex.Message);}
class Book
{
    private string name;
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

    private string? name;
    private int sheets;
    private decimal price;

    public string? Name { get { return name; } set { if (value != null) name = value; } }

    public int Sheets
    {
        get { return sheets; }
        set { if (value >= 0) sheets = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { if (value >= 0) price = value; }
    }

    public string Discount(decimal Price) // Так как не было в задании указано критериев скидки, я сделал её произвольно.
    { 
        Random random = new Random();
        int a = random.Next(0,21);
        return $"Стоимость книги {Name} с учётом скидки ({a}%) составляет {(Price - (Price * a / 100)):F2}.";
    }

    public string FullInfo(string? Name)
    {
        return $"Название книги: {Name}, количество страниц: {Sheets}, стоимость без учёта скидки: {Price}." + Discount(Price);
    }
    public Library(string name, int sheets, decimal price) : base(name, sheets, price)
    {
        this.name = base.Name;
        this.sheets = base.Sheets;
        this.price = base.Price;
    }
}