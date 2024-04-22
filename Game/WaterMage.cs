using System;

public class WaterMage : Mage
{
    public WaterMage(string name, int magicLevel) : base(name, magicLevel) { }

    public override void Attack(Mage target)
    {
        WaterSpell spell = new WaterSpell();
        spell.CastSpell(this, target);
    }

    public override void Defend()
    {
        Health += 15;
        Console.WriteLine($"{Name} викликає водяний бар'єр і отримує 15 здоров'я.");
    }
}
