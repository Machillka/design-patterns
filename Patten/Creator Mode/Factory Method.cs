using Product;

namespace Factory
{
    // 简单工厂模式
    public static class SimpleFactory
    {
        public static Animal CreateAnimal(string animalName)
        {
            return animalName switch
            {
                "Dog" => new Dog(),
                "Bird" => new Bird(),
                "PenPen" => new PenPen(),
                _ => throw new NotImplementedException()
            };
        }
    }

    // 工厂模式
    public abstract class FactoryModeCreator
    {
        public abstract ICar FactoryMethod();

        // 可以加入 业务逻辑 通过抽象产品的接口与产品交互
        public ICar CreateFunction()
        {
            var product = FactoryMethod();
            Console.WriteLine("I'm " + product.Test());
            return product;
        }
    }

    public class BenzCreator : FactoryModeCreator
    {
        public override ICar FactoryMethod() => new Benz();
    }

    public class FordCreator : FactoryModeCreator
    {
        public override ICar FactoryMethod() => new Ford();
    }
}