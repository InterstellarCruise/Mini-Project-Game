public static class Program
{

    public static void Main()
    {   
        Welcome();
        int loc = 0;
        bool game = true;
        while (game)
        {
            Console.WriteLine("Press W to move");
            ConsoleKey walk = Console.ReadKey().Key;
            if (walk == ConsoleKey.W)
            {
                loc++;
            }
            Location LocationObject = World.LocationByID(loc);
            Console.WriteLine(LocationObject.Name);
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