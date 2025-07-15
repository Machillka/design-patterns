using Director;
using Builder;
using Factory;
using Product;

public class Program
{
    public static void Main(string[] args)
    {
        #region 工厂测试
        // 简单工厂
        Animal jack = Factory.SimpleFactory.CreateAnimal("Bird");
        jack.Feed();

        if (jack is Bird jackBird)
        {
            jackBird.Fly();
        }

        // 工厂模式
        FactoryModeCreator BenzFactor = new BenzCreator();
        ICar benz = BenzFactor.FactoryMethod();
        benz.Drive();

        FactoryModeCreator FordFactor = new FordCreator();
        ICar ford = FordFactor.CreateFunction();
        #endregion

        #region 建造者模式
        CharacterBuilder warriorBuilder = new CharacterBuilder();
        WarriorDirector warriorDirector = new WarriorDirector(warriorBuilder);

        Character arthur = warriorDirector.ConstructWarrior("Arthur");
        Console.WriteLine(arthur);

        #endregion
    }
}