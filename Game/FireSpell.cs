using System;

public class FireSpell : ISpell
{
    public void CastSpell(Mage caster, Mage target)
    {
        Random rand = new Random();
        int damage = rand.Next(10, 21) * caster.MagicLevel;
        target.ReceiveDamage(damage);
        Console.WriteLine($"{caster.Name} кидає вогняний куля в {target.Name} і завдає {damage} ушкодження.");
        caster.OnSpellCast(caster, target, damage);
    }
}
