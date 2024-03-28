using System;
using UnityEngine;

namespace Quirks.Directions
{
    public class Directions3D
    {
        /// <summary>Return the movement Direction in 3D Space</summary>
        public static Direction3D GetDirection3D(float xOne, float yOne, float zOne, float xTwo, float yTwo, float zTwo)
        {
            float x = xOne + xTwo;
            float y = yOne + yTwo;
            float z = zOne + zTwo;

            float xStrength = (float)Math.Pow(x, 2);
            float yStrength = (float)Math.Pow(y, 2);
            float zStrength = (float)Math.Pow(z, 2);

            if (zStrength >= yStrength)
            {
                if (zStrength >= xStrength) // Z is Better
                {
                    return z >= 0 ? Direction3D.Forward : Direction3D.Back;
                }
                else // X is Better
                {
                    return x >= 0 ? Direction3D.Right : Direction3D.Left;
                }
            }
            else
            {
                if (yStrength >= xStrength) // Y is Better
                {
                    return y >= 0 ? Direction3D.Up : Direction3D.Down;
                }
                else // X is Better
                {
                    return x >= 0 ? Direction3D.Right : Direction3D.Left;
                }
            }
        }

        /// <summary>Return the movement Direction in 3D Space</summary>
        /// <param name="startPoint">First Coordinate Input</param>
        /// <param name="endPoint">Second Coordinate Input</param>
        public static Direction3D GetDirection3D(Vector3 startPoint, Vector3 endPoint)
            => GetDirection3D(startPoint.x, startPoint.y, startPoint.z, endPoint.x, endPoint.y, endPoint.z);

    }

}
