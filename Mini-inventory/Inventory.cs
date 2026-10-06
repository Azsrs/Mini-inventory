using System;

namespace Mini_inventory;

public class Inventory
{

    private List<Item> _items = [];

    private int _carryingCapacity = 100;


    public List<Item> AddStuff(Item item)
    {
        if (_carryingCapacity > 0)
        {
            _items.Add(item);
            _carryingCapacity -= (int)item.GetWeight();
            if (_carryingCapacity < 0)
            {
                _items.Remove(item);
                Console.WriteLine("You are carrying too much");
            }
        }
        else Console.WriteLine("You are carrying too much");
        return _items;
    }

    public void Display()
    {
        int i = 1;
        Console.WriteLine("Nuvarande förråd:");
        foreach (Item Item in _items)
        {
            Console.WriteLine(i + ". " + Item.GetName() + "   Weight:" + Item.GetWeight());
            i++;
        }
    }

}
