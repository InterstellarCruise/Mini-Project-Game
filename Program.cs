public static class Program
{

    public static void Main()
    {
        int loc = 0;
        bool game = true;
        ConsoleKey walk = Console.ReadKey().Key;
        while (walk != ConsoleKey.Q)
        {
            Console.WriteLine("Press W to move");
            walk = Console.ReadKey().Key;
            Console.WriteLine("");
            if (walk == ConsoleKey.W)
            {
                loc++;
            }
            if (walk == ConsoleKey.Q)
            {
                Console.WriteLine("You have quit the game!");
            }

            Location LocationObject = World.LocationByID(loc);
            Console.WriteLine(LocationObject.Name);
            Console.WriteLine(LocationObject.Description);
            Console.WriteLine(((LocationObject.LocationToNorth != null) ? LocationObject.LocationToNorth.Name : (LocationObject.LocationToEast != null) ? LocationObject.LocationToEast.Name : (LocationObject.LocationToSouth != null) ? LocationObject.LocationToSouth.Name : (LocationObject.LocationToWest != null) ? LocationObject.LocationToWest.Name : "No Locations nearby"));

        }
        
    }
        public static void Welcome()
    {
        Console.WriteLine("Hello Traveller, here starts your Adventure.\nPlease tell me your name.");
        string? playersName = Console.ReadLine();
        Player player = new Player(playersName, 50, 5, 0, 0, 0, null, null, null, null);
    }
}