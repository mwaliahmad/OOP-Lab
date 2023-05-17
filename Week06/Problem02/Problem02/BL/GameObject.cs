using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.BL
{
    public class GameObject
    {
        public GameObject()
        {
            Shape = new char[1, 3] { { '-', '-', '-' } };
            Start = new Point();
            Premises = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] Shape, Point Start)
        {
            this.Shape = Shape;
            this.Start = Start;
            Premises = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] Shape, Point Start, Boundary Premises, string Direction)
        {
            this.Shape = Shape;
            this.Start = Start;
            this.Premises = Premises;
            this.Direction = Direction;
        }
        public char[,] Shape;
        public Point Start;
        public Boundary Premises;
        public string Direction;
        public void Draw()
        {
            int x = Start.X;
            int y = Start.Y;
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.Write(Shape[i, j]);
                }
                y++;
            }
        }
        public void Erase()
        {
            int x = Start.X;
            int y = Start.Y;
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.Write(" ");
                }
                y++;
            }
        }
        public void Move()
        {
            if (Direction == "LeftToRight" && (Start.X > 0 && Start.X < 90) && (Start.Y > 0 && Start.Y < 90))
            {
                Start.X++;
            }
            if (Direction == "RightToLeft" && (Start.X > 0 && Start.X < 90) && (Start.Y > 0 && Start.Y < 90))
            {
                Start.X--;
            }
            if (Direction == "Patrol" && (Start.X > 0 && Start.X < 90) && (Start.Y > 0 && Start.Y < 90))
            {
                Start.X--;
            }
        }
    }
}
