using System;

namespace Mini_inventory;

public class Inventory
{

    private List<Item> Items;

    public void Display()
    {
        foreach (Item Item in Items)
        {
            Console.WriteLine(Item);
        }
    }

}
