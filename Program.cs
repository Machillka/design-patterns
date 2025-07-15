using Factory;
using Product;

public class Program
{
    public static void Main(string[] args)
    {
        // 使用简单工厂来创建动物
        Animal jack = Factory.SimpleFactory.CreateAnimal("Bird");
        jack.Feed();

        if (jack is Bird jackBird)
        {
            jackBird.Fly();
        }

        FactoryModeCreator BenzFactor = new BenzCreator();
        ICar benz = BenzFactor.FactoryMethod();
        benz.Drive();

        FactoryModeCreator FordFactor = new FordCreator();
        ICar ford = FordFactor.CreateFunction();
    }
}