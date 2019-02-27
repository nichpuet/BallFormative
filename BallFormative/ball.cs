using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallFormative
{
    class ball
    {
        public int x, y, size, r, g, b, moveSpeed;

        public ball(int _x, int _y, int _size, int _r, int _g, int _b, int _moveSpeed)
        {
            x = _x;
            y = _y;
            size = _size;
            r = _r;
            g = _g;
            b = _b;
            moveSpeed = _moveSpeed;
        }

        public void ballMove(string direction)
        {
            if (direction == "left")
            {
                x = x - moveSpeed;
            }
            else if (direction == "right")
            {
                x = x + moveSpeed;
            }
            else if (direction == "up")
            {
                y = y + moveSpeed;
            }
            else if (direction == "down")
            {
                y = y - moveSpeed;
            }
        }
    }
}
