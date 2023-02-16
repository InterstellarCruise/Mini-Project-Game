public static class Program
{

    public static void Main()
    {
        int loc = 0;
        bool game = true;
        while (game)
        {
            Console.WriteLine("Press W to move");
            char walk = Convert.ToChar(Console.ReadLine().ToUpper());
            if (walk == 'W')
            {
                loc++;
            }
            Location LocationObject = World.LocationByID(loc);
            Console.WriteLine(LocationObject.Name);
            Console.WriteLine(((LocationObject.LocationToNorth != null) ? LocationObject.LocationToNorth.Name : (LocationObject.LocationToEast != null) ? LocationObject.LocationToEast.Name : (LocationObject.LocationToSouth != null) ? LocationObject.LocationToSouth.Name : (LocationObject.LocationToWest != null) ? LocationObject.LocationToWest.Name : "No Locations nearby"));





        }
    }
}