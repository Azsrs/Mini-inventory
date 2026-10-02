using System;

namespace Mini_inventory;

public class Character
{
    private int _hp;
    private string _name;
    private Inventory Backpack;

    public int Hp
    {
        get => _hp;
        set
        {
            _hp = value;
            if (_hp < 0) _hp = 0;
        }
    }

    public Character(string Name)
    {
        _name = Name;
        _hp = 100;
    }

    public void AddToInventory(Item Input)
    {
        Backpack.Add(Input);
    }
}
