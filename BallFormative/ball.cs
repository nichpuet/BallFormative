using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallFormative
{
    class ball
    {
        int x, y, size, r, g, b, moveSpeed;

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
    }
}
