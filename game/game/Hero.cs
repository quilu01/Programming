using game;

public class Hero
{
    Random rnd = new Random();
    private string _name;
    private string _description;
    private int _damage;
    private double _health;
    private int _level;

    public int Level { get; set; }
    public Abilities Ability { get; set; }
    public string Name
    {
        get { return _name; }
        set { if (value.Length < 50) { _name = value; } }
    }
    public string Description
    {
        get { return _description; }
        set { if (value.Length < 150) { _description = value; } }    
    }
    public int Damage
    {
        get { return (int)_damage; }
        set { if (value > 0) { _damage = value; } }
    }
    public double Health
    {
        get { return _health; }
        set { if (value > 0) { _health = value; } }
    }
    public Hero()
    {
        
        Ability = GetAbility();
        Health = rnd.Next(20, 40);
        Damage = rnd.Next(2, 4);
        Description = GetDescription(Health, Damage, Ability);
        Name = "Unknown";
        Level = 1;
    }

    private Abilities GetAbility()
    {
        int chance = rnd.Next(1, 101);
        if (chance == 1) { return Abilities.Blood; }
        if (1 < chance && chance <= 20) { return Abilities.Ice; }
        if (21 <= chance && chance <= 40) { return Abilities.Armor; }
        if (41 <= chance && chance <= 60) { return Abilities.Fire; }
        else { return Abilities.None; }
    }
    private string GetDescription(double health, int damage, Abilities ability)
    {
        if (ability != Abilities.None) { return "powerful hero"; }
        if (health > 30 && damage > 2) { return "strong hero"; }
        else { return "average hero"; }
        
    }

}

