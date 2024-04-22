using System;

public class WaterSpell : ISpell
{
    public void CastSpell(Mage caster, Mage target)
    {
        Random rand = new Random();
        int damage = rand.Next(5, 16) * caster.MagicLevel;
        target.ReceiveDamage(damage);
        Console.WriteLine($"{caster.Name} кидає водяний потік в {target.Name} і завдає {damage} ушкодження.");
        caster.OnSpellCast(caster, target, damage);
    }
}
