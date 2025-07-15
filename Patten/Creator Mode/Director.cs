using Builder;

namespace Director;

//指挥者 指挥生成的产品需要什么属性
public class WarriorDirector(ICharacterBuilder characterBuilder)
{
    // 构造函数的简写
    private ICharacterBuilder _characterBuilder = characterBuilder;

    // 生成一个战士
    public Character ConstructWarrior(string name)
    {
        return _characterBuilder.SetName(name)                      // 创建各种属性
                .SetWeapon("长剑")
                .SetMana(60)
                .SetStrength(100)
                .Build();                                           // 返回创建后的角色
    }
}

public class ShamanDirector(ICharacterBuilder characterBuilder)
{
    // 构造函数的简写
    private ICharacterBuilder _characterBuilder = characterBuilder;

    // 生成一个萨满
    public Character ConstructWarrior(string name)
    {
        return _characterBuilder.SetName(name)                      // 创建各种属性
                .SetWeapon("法杖")
                .SetMana(100)
                .SetStrength(60)
                .Build();                                           // 返回创建后的角色
    }
}