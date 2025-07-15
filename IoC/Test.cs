using Builder;
using Director;
using Factory;
using Product;

namespace Test;

// 用于测试模块
public interface ITest
{
    void RunTest();
}

public class FactoryTest : ITest
{
    public void RunTest()
    {
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
    }
}

public class BuilderTest : ITest
{
    public void RunTest()
    {
        CharacterBuilder warriorBuilder = new CharacterBuilder();
        WarriorDirector warriorDirector = new WarriorDirector(warriorBuilder);

        Character arthur = warriorDirector.ConstructWarrior("Arthur");
        Console.WriteLine(arthur);
    }
}

// 定义所有测试模块
public class TestBlock
{
    public List<ITest> tests = new List<ITest>();

    public void RunAllTest()
    {
        foreach (var test in tests)
        {
            test.RunTest();
        }
    }

    public void AddTest(ITest newTest)
    {
        tests.Add(newTest);
    }
}