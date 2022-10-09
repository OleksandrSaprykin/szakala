using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangles
{
    public static class RectanglesTask
    {
        // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            return Math.Max(r1.Top, r2.Top) <= Math.Min(r1.Bottom, r2.Bottom) && Math.Max(r1.Left, r2.Left) <= Math.Min(r1.Right, r2.Right);

        }

        // Площадь пересечения прямоугольников
        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            int left = Math.Max(r1.Left, r2.Left);
            int right = Math.Min(r1.Right, r2.Right);
            int top = Math.Max(r1.Top, r2.Top);
            int bottom = Math.Min(r1.Bottom, r2.Bottom);

            int width = right - left;
            int height = bottom - top;

            if (width <= 0 || height <= 0)
                return 0;

            return width * height;
        }

        // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
        // Иначе вернуть -1
        // Если прямоугольники совпадают, можно вернуть номер любого из них.
        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (r1.Right >= r2.Right && r1.Left <= r2.Left && r1.Bottom >= r2.Bottom && r1.Top <= r2.Top)
                return 1;

            if (r2.Right >= r1.Right && r2.Left <= r1.Left && r2.Bottom >= r1.Bottom && r2.Top <= r1.Top)
                return 0;

            if (r1.Right == r2.Right && r1.Bottom == r2.Bottom && r1.Top == r2.Top && r1.Left == r2.Left)
                return 1;

            return -1;
        }
    }
}