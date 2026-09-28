using System;

namespace Mini_inventory;

public class Character
{
    private int _hp;
    private string _name;

    public int Hp
    {
        get => _hp;
        set
        {
            _hp = value;
            if (_hp < 0) _hp = 0;
        }
    }

    
}
