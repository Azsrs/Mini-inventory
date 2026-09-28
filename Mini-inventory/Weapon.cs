using System;

namespace Mini_inventory;

public class Weapon : Item
{
    private int _minDamage;
    private int _maxDamage;

    public int Attack()
    {
       return Random.Shared.Next(_minDamage, _maxDamage);
    }
}
