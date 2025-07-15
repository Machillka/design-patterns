namespace Product;

public interface ICar
{
    public string Test();
    public void Drive();
    public void Repair();
}

// 具体产品
public class Benz : ICar
{
    public string Test() => "Testing Benz";

    public void Drive()
    {
        Console.WriteLine("I'm Driving Benz");
    }

    public void Repair()
    {
        Console.WriteLine("Benz's Repair Function");
    }
}

public class Ford : ICar
{
    public string Test() => "Testing Ford";

    public void Drive()
    {
        Console.WriteLine("I'm Driving Ford");
    }

    public void Repair()
    {
        Console.WriteLine("Ford's Repair Function");
    }
}