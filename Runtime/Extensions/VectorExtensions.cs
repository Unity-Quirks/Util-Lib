using System.Runtime.CompilerServices;
using UnityEngine;

namespace Quirks
{
    public static class VectorExtensions
    {
        #region Vector2

        #region Conversion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int ToVector2Int(this Vector2 vector) => new Vector2Int(Mathq.RoundToInt(vector.x), Mathq.RoundToInt(vector.y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ToVector3(this Vector2 vector) => new Vector3(vector.x, vector.y, 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int ToVector3Int(this Vector2 vector) => new Vector3Int(Mathq.RoundToInt(vector.x), Mathq.RoundToInt(vector.y), 0);

        #endregion

        #region Math

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Floor(this Vector2 vector) => new Vector2(Mathq.Floor(vector.x), Mathq.Floor(vector.y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int FloorToInt(this Vector2 vector) => new Vector2Int(Mathq.FloorToInt(vector.x), Mathq.FloorToInt(vector.y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Ceil(this Vector2 vector) => new Vector2(Mathq.Ceil(vector.x), Mathq.Ceil(vector.y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int CeilToInt(this Vector2 vector) => new Vector2Int(Mathq.CeilToInt(vector.x), Mathq.CeilToInt(vector.y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Abs(this Vector2 vector) => new Vector2(Mathq.Abs(vector.x), Mathq.Abs(vector.y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sign(this Vector2 vector) => new Vector2(Mathq.Sign(vector.x), Mathq.Sign(vector.y));

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Rotate(this Vector2 vector, float degrees)
        {
            float radians = degrees * Mathf.Deg2Rad;
            float cos = Trigq.Cos(radians);
            float sin = Trigq.Sin(radians);

            return new Vector2(vector.x * cos - vector.y * sin, vector.x * sin + vector.y * cos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 RotateAround(this Vector2 point, Vector2 center, float degrees)
        {
            Vector2 dir = point - center;
            dir = dir.Rotate(degrees);

            return center + dir;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 SnapToGrid(this Vector2 vector, float gridSize) => new Vector2(Mathq.Round(vector.x / gridSize) * gridSize, Mathq.Round(vector.y / gridSize) * gridSize);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 SnapToGrid(this Vector2 vector, Vector2 gridSize) => new Vector2(Mathq.Round(vector.x / gridSize.x) * gridSize.x, Mathq.Round(vector.y / gridSize.y) * gridSize.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 FloorToGrid(this Vector2 vector, float gridSize) => new Vector2(Mathq.Floor(vector.x / gridSize) * gridSize, Mathq.Floor(vector.y / gridSize) * gridSize);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 FloorToGrid(this Vector2 vector, Vector2 gridSize) => new Vector2(Mathq.Floor(vector.x / gridSize.x) * gridSize.x, Mathq.Floor(vector.y / gridSize.y) * gridSize.y);

        #region Unnecessary but Necessary

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Lerp(this Vector2 a, Vector2 b, float t) => Vector2.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 LerpUnclamped(this Vector2 a, Vector2 b, float t) => Vector2.LerpUnclamped(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 MoveTowards(this Vector2 current, Vector2 target, float maxDistanceDelta) => Vector2.MoveTowards(current, target, maxDistanceDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Reflect(this Vector2 vector, Vector2 normal) => Vector2.Reflect(vector, normal);

        #endregion

        #region Screen & World Space

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 ScreenToViewport(this Vector2 screenPoint)
        {
            return new Vector2(screenPoint.x / Screen.width, screenPoint.y / Screen.height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 ViewportToScreen(this Vector2 viewportPoint)
        {
            return new Vector2(viewportPoint.x * Screen.width, viewportPoint.y * Screen.height);
        }

        #endregion

        #endregion
    }
}