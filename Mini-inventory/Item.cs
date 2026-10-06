using System;

namespace Mini_inventory;

public class Item
{
    private string _name;
    private float _weight;

    public Item(string Name, int Weight)
    {
        _name = Name;
        _weight = Weight;
    }

    public string GetName()
    {
        return _name;
    }

    public float GetWeight()
    {
        return _weight;
    }
}
