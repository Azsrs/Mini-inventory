using System;
using System.Runtime;

namespace Mini_inventory;

public class Consumable : Item
{
    private int _usesMax;
    private int _usesCurrent;

    public void Use(Character Target)
    {
        if (_usesCurrent <= _usesMax)
        {
            Target.Hp += 10;
        }
        else Console.WriteLine("Du har slut på charges, potion användes ej");
    }
}
