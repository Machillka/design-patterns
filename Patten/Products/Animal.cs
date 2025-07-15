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
}