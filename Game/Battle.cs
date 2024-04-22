using System;

public class Battle
{
    private Mage mage1;
    private Mage mage2;

    public Battle(Mage mage1, Mage mage2)
    {
        this.mage1 = mage1;
        this.mage2 = mage2;
    }

    public void StartBattle()
    {
        Console.WriteLine($"Битва між {mage1.Name} та {mage2.Name} розпочалася!");
        while (mage1.Health > 0 && mage2.Health > 0)
        {
            mage1.Attack(mage2);
            if (mage2.Health <= 0)
            {
                Console.WriteLine($"{mage1.Name} перемагає!");
                break;
            }
            mage2.Attack(mage1);
            if (mage1.Health <= 0)
            {
                Console.WriteLine($"{mage2.Name} перемагає!");
                break;
            }
        }
    }
}