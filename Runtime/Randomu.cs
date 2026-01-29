using System.Runtime.CompilerServices;
using UnityEngine;

namespace Quirks
{
    public static partial class Randomq
    {
        public static Vector2 Vector2 => new Vector2(Float, Float);
        public static Vector3 Vector3 => new Vector3(Float, Float, Float);

        #region Range

        #region  Vector2

        /// <summary>Returns a Random Vector2 between (0, 0) and max</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Range(Vector2 max) => Vector2 * max;

        /// <summary>Returns a Random Vector2 between the min and max</summary>
        /// <param name="min">Smallest vector</param>
        /// <param name="max">Largest vector</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Range(Vector2 min, Vector2 max) => (Vector2 * (max - min) + min);

        #endregion

        #region  Vector3

        /// <summary>Returns a Random Vector3 between (0, 0, 0) and max</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Range(Vector3 max) => Vector3.Scale(Vector3, max);

        /// <summary>Returns a Random Vector3 between the min and max</summary>
        /// <param name="min">Smallest vector</param>
        /// <param name="max">Largest vector</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Range(Vector3 min, Vector3 max) => Vector3.Scale(Vector3, (max - min)) + min;

        #endregion

        #endregion

        #region Area

        #region Vector2

        /// <summary>Returns random Coordinate around center</summary>
        /// <param name="center">Center Point</param>
        /// <param name="radius">Area Radius</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Area(Vector2 center, float radius) => Vector2 * radius + center;

        /// <summary>Returns random Coordinate around center within range</summary>
        /// <param name="center">Center Point</param>
        /// <param name="minRadius">Min Radius Area</param>
        /// <param name="maxRadius">Max Radius Area</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Area(Vector2 center, float minRadius, float maxRadius)
        {
            float x = Range(minRadius, maxRadius);
            float y = Range(minRadius, maxRadius);

            return new Vector2(x, y) + center;
        }

        #endregion

        #region Vector3

        /// <summary>Returns random Coordinate around center</summary>
        /// <param name="center">Center Point</param>
        /// <param name="radius">Area Radius</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Area(Vector3 center, float radius) => Vector3 * radius + center;

        /// <summary>Returns random Coordinate around center within range</summary>
        /// <param name="center">Center Point</param>
        /// <param name="minRadius">Min Radius Area</param>
        /// <param name="maxRadius">Max Radius Area</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Area(Vector3 center, float minRadius, float maxRadius)
        {
            float x = Range(minRadius, maxRadius);
            float y = Range(minRadius, maxRadius);
            float z = Range(minRadius, maxRadius);

            return new Vector3(x, y, z) + center;
        }

        #endregion

        #endregion


    }
}
