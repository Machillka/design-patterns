// public abstract class AnimalBase
// {
//     // 所有 Animal 都有的 并且可以随时读写
//     public int Id { get; set; }

//     // 所有 Animal 都有名字，但是需要自己去实现自己的名字是什么
//     public abstract string Name { get; }
// }

// public sealed class Dog : AnimalBase
// {
//     public override string Name => "Dog";
// }

// public class Cat : AnimalBase
// {
//     // 使用 override 表示重载 abstract 中定义的属性
//     public override string Name => "Cat";

//     // 只有 Cat 才有捕捉老鼠的行为 所以定义为成员
//     public void CatchMouse()
//     {
//         Console.WriteLine("This cat is catching a mouse");
//     }
// }

// public class Person
// {
//     public virtual string Name => "Nobody";
// }

// public class Tom : Person
// {
//     public override string Name => "Tom";
// }

// public class Nobody : Person
// {
//     public void LoudOutSadness()
//     {
//         // 输出就是 Person 的默认实现, 即 Nobody
//         Console.WriteLine(Name);
//     }
// }