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

            if (player.CurrentLocation.QuestAvailableHere != null)
            {
                Console.WriteLine(player.CurrentLocation.QuestAvailableHere.QuestName);
                Console.WriteLine(player.CurrentLocation.QuestAvailableHere.QuestDescription);
                Console.WriteLine("Do you wish to accept this quest? Y/N");
                string? answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    Console.Write("Great get to it then!");
                }
            }

            if (player.CurrentLocation.MonsterLivingHere != null)
            {
                var choice1 = "";
                while (choice1 != "A")
                {
                    Console.WriteLine($"A: Approach the {player.CurrentLocation.MonsterLivingHere.Name}\nC: Change weapon");
                    choice1 = Console.ReadLine();
                    choice1 = choice1.ToUpper();
                    if (choice1 == "C")
                    {
                        Weapon newweapon = World.Weapons.FirstOrDefault(Weapon => Weapon.ID != player.CurrentWeapon.ID);
                        if (newweapon != null)
                        {
                            player.CurrentWeapon = newweapon;
                            Console.WriteLine($"Your new weapon: {player.CurrentWeapon.WeaponName}");
                        }
                        else
                        {
                            Console.WriteLine("You don't have any other");
                        }
                    }
                }

                string winner = "";
                while (winner == "")
                {
                    Console.WriteLine($"\n{player.Name}: {player.CurrentHitPoints} HP");
                    Console.WriteLine($"{player.CurrentLocation.MonsterLivingHere.Name}: {player.CurrentLocation.MonsterLivingHere.CurrentHitPoints} HP\n");
                    Console.WriteLine("A: Attack\nH: Heal up");
                    var choice = Console.ReadLine();
                    choice = choice.ToUpper();
                    if (choice == "A")
                    {
                        Random rnd = new Random();
                        int damagemonster = rnd.Next(1, player.CurrentLocation.MonsterLivingHere.MaximumDamage);
                        int damageplayer = rnd.Next(player.CurrentWeapon.MinimnumDamage, player.CurrentWeapon.MaximumDamage);
                        player.CurrentLocation.MonsterLivingHere.TakeDamage(damageplayer);
                        player.TakeDamage(damagemonster);
                        if (player.IsAlive() == false)
                        {
                            winner = player.CurrentLocation.MonsterLivingHere.Name;
                            Console.WriteLine($"You Lost! The {player.CurrentLocation.MonsterLivingHere.Name} has {player.CurrentLocation.MonsterLivingHere.CurrentHitPoints} HP left!");
                        }
                        else if (player.CurrentLocation.MonsterLivingHere.IsAlive() == false)
                        {
                            winner = player.Name;
                            Console.WriteLine($"\n{player.Name} was victorious over the scary {player.CurrentLocation.MonsterLivingHere.Name}");

                            Console.WriteLine($"You got {player.CurrentLocation.MonsterLivingHere.loot}!");
                        }
                    }
                    else if (choice == "H")
                    {
                        while (player.CurrentHitPoints <= player.MaximumHitPoints)
                        {
                            player.CurrentHitPoints += 10;
                            Console.WriteLine($"{player.Name} healed up and now has {player.CurrentHitPoints} HP");
                        }
                        player.CurrentHitPoints = player.MaximumHitPoints;
                        Console.WriteLine($"You have {player.CurrentHitPoints}, you can't heal anymore!");

                    }
                }
            }
        }
        Console.WriteLine("Goodbye traveller!");
    }
}

