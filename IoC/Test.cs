using Builder;
using Director;
using Factory;
using Product;
using Adapter;

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

public class AdapterTest : ITest
{
    public void RunTest()
    {
        ApplePalSdk applePaySdk = new ApplePalSdk();
        ApplePayAdapter applePay = new ApplePayAdapter(applePaySdk);
        applePay.Process(100, "英镑");

        PayPalAdapter payPalAdapter = new PayPalAdapter(new PayPalSdk());
        payPalAdapter.Process(10, "美元");
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
            Console.WriteLine("Testing: " + test.GetType());
            test.RunTest();
            Console.WriteLine("");
        }
    }

    public void AddTest(ITest newTest)
    {
        tests.Add(newTest);
    }
}