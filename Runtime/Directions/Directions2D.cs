using System;
using UnityEngine;

namespace Quirks.Directions
{
    public class Directions2D
    {
        /// <summary>2D Direction Property</summary>
        public enum Direction2D { Up, Down, Left, Right };

        /// <summary>Returns the movement Direction in 2D Space</summary>
        public static Direction2D GetDirection2D(float xOne, float yOne, float xTwo, float yTwo)
        {
            float x = xOne + xTwo;
            float y = yOne + yTwo;

            float xStrength = (float)Math.Pow(x, 2);
            float yStrength = (float)Math.Pow(y, 2);

            if (yStrength >= xStrength) // Up Down
            {
                return y >= 0 ? Direction2D.Up : Direction2D.Down;
            }
            else
            {
                return x >= 0 ? Direction2D.Right : Direction2D.Left;
            }
        }

        /// <summary>Returns the movement Direction in 2D Space</summary>
        /// <param name="startPoint">First Coordinate Input</param>
        /// <param name="endPoint">Second Coordinate Input</param>
        public static Direction2D GetDirection2D(Vector2 startPoint, Vector2 endPoint) => GetDirection2D(startPoint.x, startPoint.y, endPoint.x, endPoint.y);
    }
}
