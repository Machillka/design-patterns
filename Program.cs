using Test;

public class Program
{
    public static void Main(string[] args)
    {
        TestBlock testList = new TestBlock();
        testList.AddTest(new FactoryTest());
        testList.AddTest(new BuilderTest());

        testList.RunAllTest();
    }
}