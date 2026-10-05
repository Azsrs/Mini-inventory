using System;

namespace Mini_inventory;

public class Inventory
{

    private List<Item> _items = [];

   
    public List<Item> AddStuff(Item item)
    {
        _items.Add(item);
        return _items;
    }

    public void Display()
    {
        foreach (Item Item in _items)
        {
            Console.WriteLine(Item);
        }
    }

}
