namespace Builder;

/// <summary>
/// 定义角色类型
/// </summary>
public class Character
{
    public string? Name { get; set; }
    public string? Weapon { get; set; }
    public int Strength { get; set; }                    // 血量
    public int Mana { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Weapon: {Weapon}, Strength: {Strength}, Mana: {Mana}";
    }
}

// 抽象构建者
public interface ICharacterBuilder
{
    ICharacterBuilder SetName(string name);
    ICharacterBuilder SetWeapon(string weapon);
    ICharacterBuilder SetStrength(int strength);
    ICharacterBuilder SetMana(int mana);

    Character Build();
}

// 具体建造者
public class CharacterBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public ICharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public ICharacterBuilder SetWeapon(string weapon)
    {
        _character.Weapon = weapon;
        return this;
    }

    public ICharacterBuilder SetStrength(int strength)
    {
        _character.Strength = strength;
        return this;
    }

    public ICharacterBuilder SetMana(int mana)
    {
        _character.Mana = mana;
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}