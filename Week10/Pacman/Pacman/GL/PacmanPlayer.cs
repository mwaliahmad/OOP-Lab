using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    public class PacmanPlayer:GameObject
    {
        public PacmanPlayer(GameObjectType type, char displayCharacter) :base(type,displayCharacter)
        {

        }
        public PacmanPlayer(char displayCharacter, GameCell cell) : base(displayCharacter,cell)
        {

        }
        /*public GameCell move(GameDirection direction)
        {
            if(direction == GameDirection.Left)
            {

            }
            else if(direction == GameDirection.Right)
            {

            }
            else if( direction == GameDirection.Up)
            {

            }
            else if (direction == GameDirection.Down)
            {

            }
            else
            {

            }
        }*/
    }
}
