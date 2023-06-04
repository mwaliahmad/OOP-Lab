using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Problem02.BL;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] optriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
            Boundary B = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameObject G1 = new GameObject(triangle, new Point(5, 5), B, "Diagonal");
            GameObject G2 = new GameObject(optriangle, new Point(30, 60), B, "RightToLeft");
            List<GameObject> obj = new List<GameObject>();
            obj.Add(G1);
            // obj.Add(G2);
            while (true)
            {
                Thread.Sleep(500);
                foreach (var G in obj)
                {
                    G.Erase();
                    G.Move();
                    G.Draw();
                }
            }
        }
    }
}
