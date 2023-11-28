using UnityEngine;

namespace Quirks
{
    public static class Distanceu
    {
        #region Manhattan

        /// <summary>Calculates the Manhattan distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static int ManhattanDistance(Vector2Int a, Vector2Int b)
        {
            return Mathf.Abs(a.x - b.x) + Mathf.Abs(a.y - b.y);
        }
        /// <summary>Calculates the Manhattan distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static float ManhattanDistance(Vector2 a, Vector2 b)
        {
            return Mathf.Abs(a.x - b.x) + Mathf.Abs(a.y - b.y);
        }

        /// <summary>Calculates the Manhattan distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static float ManhattanDistance(Vector3 a, Vector3 b)
        {
            return Mathf.Abs(a.x - b.x) + Mathf.Abs(a.y - b.y) + Mathf.Abs(a.z - b.z);
        }
        /// <summary>Calculates the Manhattan distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static int ManhattanDistance(Vector3Int a, Vector3Int b)
        {
            return Mathf.Abs(a.x - b.x) + Mathf.Abs(a.y - b.y) + Mathf.Abs(a.z - b.z);
        }

        #endregion

        #region Euclidian

        /// <summary>Calculates the Euclidean distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static float EuclideanDistance(Vector2 a, Vector2 b)
        {
            return (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y);
        }
        /// <summary>Calculates the Euclidean distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static int EuclideanDistance(Vector2Int a, Vector2Int b)
        {
            return (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y);
        }

        /// <summary>Calculates the Euclidean distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static float EuclideanDistance(Vector3 a, Vector3 b)
        {
            return (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y) + (a.z - b.z) * (a.z - b.z);
        }
        /// <summary>Calculates the Euclidean distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static int EuclideanDistance(Vector3Int a, Vector3Int b)
        {
            return (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y) + (a.z - b.z) * (a.z - b.z);
        }

        #endregion

        #region Chebyshev

        /// <summary>Calculates the Chebyshev distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static float ChebyshevDistance(Vector2 a, Vector2 b)
        {
            return Mathq.Max(Mathq.Abs(b.x - a.x), Mathq.Abs(b.y - a.y));
        }
        /// <summary>Calculates the Chebyshev distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static int ChebyshevDistance(Vector2Int a, Vector2Int b)
        {
            return Mathq.Max(Mathq.Abs(b.x - a.x), Mathq.Abs(b.y - a.y));
        }

        /// <summary>Calculates the Chebyshev distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static float ChebyshevDistance(Vector3 a, Vector3 b)
        {
            return Mathq.Max(Mathq.Abs(b.x - a.x), Mathq.Abs(b.y - a.y), Mathq.Abs(b.z - a.z));
        }
        /// <summary>Calculates the Chebyshev distance between two points.</summary>
        /// <param name="a">First Point</param>
        /// <param name="b">Second Point</param>
        public static int ChebyshevDistance(Vector3Int a, Vector3Int b)
        {
            return Mathq.Max(Mathq.Abs(b.x - a.x), Mathq.Abs(b.y - a.y), Mathq.Abs(b.z - a.z));
        }

        #endregion
    }
}

