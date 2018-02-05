using System;

namespace TurnBasedRPG
{
    public class Player: IMovable
    {
        public const char Sign = 'P';
        
        public Vector2 Position => position;

        private Vector2 position;
        
        public void Move(Vector2 offset)
        {
            position.X += offset.X;
            position.Y += offset.Y;

            position.X = Math.Min(Math.Max(0, position.X), Console.WindowWidth - 1);
            position.Y = Math.Min(Math.Max(0, position.Y), Console.WindowHeight - 2);
        }
    }
}