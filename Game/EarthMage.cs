using System;

public class EarthMage : Mage
{
    public EarthMage(string name, int magicLevel) : base(name, magicLevel) { }

    public override void Attack(Mage target)
    {
        EarthSpell spell = new EarthSpell();
        spell.CastSpell(this, target);
    }

    public override void Defend()
    {
        Health += 12;
        Console.WriteLine($"{Name} створює земляну стіну і отримує 12 здоров'я.");
    }
}
