using System;

public class EarthSpell : ISpell
{
    public void CastSpell(Mage caster, Mage target)
    {
        Random rand = new Random();
        int damage = rand.Next(8, 19) * caster.MagicLevel;
        target.ReceiveDamage(damage);
        Console.WriteLine($"{caster.Name} кидає кам'яний зсув в {target.Name} і завдає {damage} ушкодження.");
        caster.OnSpellCast(caster, target, damage);
    }
}
