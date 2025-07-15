namespace Product
{
    public abstract class Animal
    {
        // 模拟进食 提供默认实现
        public virtual void Feed()
        {
            Console.WriteLine("Ahaha Feeding!");
        }
    }

    public interface IFlyable
    {
        public void Fly();
    }

    public interface IRunable
    {
        public void Run();
    }

    public class Dog : Animal, IRunable
    {
        public string Name { get; } = "Dog";

        public override void Feed() => Console.WriteLine("Dog's Feed Function");
        public void Run() => Console.Write("Dog can RUN!");
    }

    public class Bird : Animal, IFlyable
    {
        public string Name { get; } = "Bird";
        public override void Feed() => Console.WriteLine("Bird's Feed Function");
        public void Fly() => Console.WriteLine("Bird can FLY!");
    }

    public class PenPen : Animal, IRunable, IFlyable
    {
        public string Name { get; } = "PenPen";
        public void Fly() => Console.WriteLine("PenPen can FLY!");
        public void Run() => Console.WriteLine("PenPen can RUN!");
    }

    // 抽象接口
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
}