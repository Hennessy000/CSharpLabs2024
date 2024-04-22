using System;

public abstract class Mage
{
    public string Name { get; }
    public int MagicLevel { get; }
    public int Health { get; protected set; }

    public event Action<Mage, Mage, int> SpellCast = delegate { };

    public Mage(string name, int magicLevel)
    {
        Name = name;
        MagicLevel = magicLevel;
        Health = 100;
    }

    public abstract void Attack(Mage target);
    public abstract void Defend();

    public void ReceiveDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
            Health = 0;
    }


    protected internal void OnSpellCast(Mage caster, Mage target, int damage)
    {
        SpellCast?.Invoke(caster, target, damage);
    }
}
