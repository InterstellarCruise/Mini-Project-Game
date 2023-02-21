public static class Program
{

    public static void Main()
    {
        Console.WriteLine("Hello Traveller, here starts your Adventure.\nPlease tell me your name.");
        string? playerName = Console.ReadLine();
        Player player = new Player(playerName, 50, 50, 0, 0, 0, World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD), World.Locations[0], null, null);
        Console.WriteLine($"Welcome {playerName}, good luck on your journey!\nIf you want to quit you can press Q anytime.");
        Console.WriteLine("\nCurrent location: " + player.CurrentLocation.Name);
        Console.WriteLine(player.CurrentLocation.Description);
        Console.WriteLine(player.CurrentLocation.Compass());

        player.TryMoveTo(player.CurrentLocation.GetLocationAt("E")); 
        while (Console.ReadLine().ToUpper() != "Q")
        {
            Console.WriteLine("Move in which direction (N/E/S/W): ");
            string input = Console.ReadLine().ToUpper();
            player.TryMoveTo(player.CurrentLocation.GetLocationAt(input));
            Console.WriteLine(player.CurrentLocation.Name);
            Console.WriteLine(player.CurrentLocation.Description);
            Console.WriteLine(player.CurrentLocation.Compass());
        }
        Console.WriteLine("Goodbye traveller!");
    }



}