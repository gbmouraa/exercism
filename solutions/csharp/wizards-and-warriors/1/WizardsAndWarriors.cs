abstract class Character
{
    public string CharacterType { get; private set; }

    protected Character(string characterType)
    {
        CharacterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {CharacterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior") { }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
            return 10;

        return 6;
    }
}

class Wizard : Character
{
    private bool HasSpell { get; set; } = false;
    private bool IsVulnerable => !HasSpell;

    public Wizard() : base("Wizard") { }

    public override int DamagePoints(Character target)
    {
        if (HasSpell)
        {
            HasSpell = false;
            return 12;
        }

        return 3;
    }

    public void PrepareSpell() { HasSpell = true; }

    public override bool Vulnerable() => IsVulnerable;

}
