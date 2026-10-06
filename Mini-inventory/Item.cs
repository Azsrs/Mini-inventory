using System;

namespace Mini_inventory;

public class Item
{
    private string _name;
    private float _weight;

    public Item(string Name)
    {
         _name = Name;
    }

    public string GetName()
    {
        return _name;
    }
}
