using System;

namespace TurnBasedRPG
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string map;
            using (FileReader reader = new FileReader())
            {
                reader.Open("Map.txt");

                map = reader.ReadAll();
            }
            
            Player player = new Player();
            player.Move(new Vector2(5, 5));

            ConsoleKey key;

            do
            {
                Console.Clear();
                
                // Render
                Console.WriteLine(map);
                Console.SetCursorPosition(player.Position.X, player.Position.Y);
                Console.Write(Player.Sign);
                
                // Get input
                key = Console.ReadKey().Key;
                
                // Process input
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        player.Move(new Vector2(0, 1));
                        break;
                    case ConsoleKey.LeftArrow:
                        player.Move(new Vector2(-1, 0));
                        break;
                    case ConsoleKey.RightArrow:
                        player.Move(new Vector2(1, 0));
                        break;
                    case ConsoleKey.UpArrow:
                        player.Move(new Vector2(0, -1));
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}