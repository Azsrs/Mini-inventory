using System;

namespace Mini_inventory;

public class Inventory
{

    private List<Item> _items;


    public void Add(Item item)
    {
        _items.Add(item);
    }
    public void Display()
    {
        foreach (Item Item in _items)
        {
            Console.WriteLine(Item);
        }
    }

}
