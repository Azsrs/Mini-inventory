using System;

namespace Mini_inventory;

public class Weapon : Item
{
    private int _minDamage;
    private int _maxDamage;


    public Weapon(string Name) : base(Name)
    {
       
    }
    public int Attack()
    {
       return Random.Shared.Next(_minDamage, _maxDamage);
    }
}
