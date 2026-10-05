using Mini_inventory;

string Name = "";

Name = GetPlayerName(Name);
Character Player = CreatePlayer(Name);
Player.DisplayInventory();
Console.ReadLine();

string YN = "";
Console.WriteLine("Du finner en hjälm på marken, plockar du upp den?");
while (YN != "y" && YN != "n") {
Console.WriteLine("[Y/N]");
YN = Console.ReadLine().ToLower();
}




static string GetPlayerName(string Name)
{
    while (Name == "")
    {
        Console.WriteLine("What is your name, brave one?");
        Name = Console.ReadLine();
    }

    return Name;
}

static Character CreatePlayer(string Name)
{
    Character Player = new(Name);
    Weapon Twig = new("Twig");
    Consumable HealthPotion = new("Health Potion");
    Player.AddToInventory(Twig);
    Player.AddToInventory(HealthPotion);
    return Player;
}