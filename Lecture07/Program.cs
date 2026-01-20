// See https://aka.ms/new-console-template for more information


Player p1 = new Player();
Player p2 = new Player(WeaponType.Bow, 300);
//p2.SetCharacterType(CharacterType.Archer);
//p2.SetName("Sophia").SetHealth(0).SetCharacterType(CharacterType.Warrior);

p1.Print();
Console.WriteLine("------------------");
p2.Print();

enum CharacterType
{
    Mage,
    Warrior,
    Archer
}

enum WeaponType
{
    Wand,
    Sword,
    Bow
}

class Weapon
{
    int damage;
    WeaponType type;

    public Weapon()
    {
    }
    
    public Weapon(WeaponType type, int damage)
    {
        this.type = type;
        this.damage = damage;
    }

    public int GetDamage()
    {
        return damage;
    }

    public Weapon SetDamage(int damage)
    {
        this.damage = damage;
        return this;
    }

    public WeaponType GetCharacterType()
    {
        return type;
    }

    public void Print()
    {
        Console.WriteLine($"Weapon type: {type}, Weapon damage: {damage}");
    }
}

class Player
{
    string name;
    int health;
    CharacterType type;
    private Weapon weapon;

    public Player()
    {
        weapon = new Weapon();
    }

    public Player(WeaponType weaponType, int damage)
    {
        weapon = new Weapon(weaponType, damage);
    }

    public string GetName()
    {
        return name;
    }

    public Player SetName(string name)
    {
        this.name = name;
        return this;
    }

    public int GetHealth()
    {
        return health;
    }

    public Player SetHealth(int health)
    {
        this.health = health;
        return this;
    }



    public CharacterType GetCharacterType()
    {
        return type;
    }

    public Player SetCharacterType(CharacterType type)
    {
        this.type = type;
        return this;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {name},  Health: {health}, Type: {type}");
      
        if (weapon != null)
            weapon.Print();

    }
    

}