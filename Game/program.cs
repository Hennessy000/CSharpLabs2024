using System;

class Program
{
    static void Main(string[] args)
    {
        FireMage fireMage = new FireMage("Вогняний Маг", 3);
        WaterMage waterMage = new WaterMage("Водяний Маг", 2);

        Battle battle = new Battle(fireMage, waterMage);
        battle.StartBattle();
    }
}
