using System;

public class FireMage : Mage
{
    public FireMage(string name, int magicLevel) : base(name, magicLevel) { }

    public override void Attack(Mage target)
    {
        FireSpell spell = new FireSpell();
        spell.CastSpell(this, target);
    }

    public override void Defend()
    {
        Health += 10;
        Console.WriteLine($"{Name} викликає вогняний щит і отримує 10 здоров'я.");
    }
}
