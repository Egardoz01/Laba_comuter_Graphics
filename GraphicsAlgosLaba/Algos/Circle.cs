using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgosLaba.Algos
{
    public static class Circle
    {
        public static void Draw(Graphics g, int center_x, int center_y, int radius)
        {
			int x = 0;
			int y = radius;
			int delta = 1 - 2 * radius;
			int sigma = 0;
			while (y >= 0)
			{
				DrawingUtils.Plot(g, center_x + x, center_y + y);
				DrawingUtils.Plot(g, center_x + x, center_y - y);
				DrawingUtils.Plot(g, center_x - x, center_y + y);
				DrawingUtils.Plot(g, center_x - x, center_y - y);

				sigma = 2 * (delta + y) - 1;
				if (delta < 0 && sigma <= 0)
				{
					x++;
					delta += 2 * x + 1;
					continue;
				}
				sigma = 2 * (delta - x) - 1;
				if (delta > 0 && sigma > 0)
				{
					y--;
					delta += 1 - 2 * y;
					continue;
				}
				x++;
				delta += 2 * (x - y);
				y--;
			}
		}
    }
}
