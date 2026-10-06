using System;
using System.Net.Security;

namespace Mini_inventory;

public class Armor : Item
{
    private float _protection;

    public Armor(string Name, int Weight) : base(Name, Weight)
    {
    }
}
