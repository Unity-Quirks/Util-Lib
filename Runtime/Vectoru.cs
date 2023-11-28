using UnityEngine;

namespace Quirks
{
    public static class Vectoru
    {
        /// <summary>Returns random Coordinate around startPosition</summary>
        /// <param name="startPosition">Center Point</param>
        /// <param name="radius">Area Radius</param>
        public static Vector2 GetRandomVectorArea(Vector2 startPosition, float radius)
        {
            System.Random rnd = new System.Random();

            float rndX = (float)rnd.NextDouble() * radius;
            float rndY = (float)rnd.NextDouble() * radius;

            Vector2 newPosition = new Vector2(startPosition.x + rndX, startPosition.y + rndY);

            return newPosition;
        }

        /// <summary>Returns random Coordinate around startPosition within range</summary>
        /// <param name="startPosition">Center Point</param>
        /// <param name="radiusMin">Min Radius Area</param>
        /// <param name="radiusMax">Max Radius Area</param>
        public static Vector2 GetRandomVectorAreaRange(Vector2 startPosition, float radiusMin, float radiusMax)
        {
            System.Random rnd = new System.Random();

            float rndX = (float)rnd.NextDouble() * (radiusMax - radiusMin) + radiusMin;
            float rndY = (float)rnd.NextDouble() * (radiusMax - radiusMin) + radiusMin;

            Vector2 newPosition = new Vector2(startPosition.x + rndX, startPosition.y + rndY);

            return newPosition;
        }

        /// <summary>Returns random Coordinate around startPosition</summary>
        /// <param name="startPosition">Center Point</param>
        /// <param name="radius">Area Radius</param>
        public static Vector3 GetRandomVectorArea(Vector3 startPosition, float radius)
        {
            System.Random rnd = new System.Random();

            float rndX = (float)rnd.NextDouble() * radius;
            float rndY = (float)rnd.NextDouble() * radius;
            float rndZ = (float)rnd.NextDouble() * radius;

            Vector3 newPosition = new Vector3(startPosition.x + rndX, startPosition.y + rndY, startPosition.z + rndZ);

            return newPosition;
        }

        /// <summary>Returns random Coordinate around startPosition within range</summary>
        /// <param name="startPosition">Center Point</param>
        /// <param name="radiusMin">Min Radius Area</param>
        /// <param name="radiusMax">Max Radius Area</param>
        public static Vector3 GetRandomVectorAreaRange(Vector3 startPosition, float radiusMin, float radiusMax)
        {
            System.Random rnd = new System.Random();

            float rndX = (float)rnd.NextDouble() * (radiusMax - radiusMin) + radiusMin;
            float rndY = (float)rnd.NextDouble() * (radiusMax - radiusMin) + radiusMin;
            float rndZ = (float)rnd.NextDouble() * (radiusMax - radiusMin) + radiusMin;

            Vector3 newPosition = new Vector3(startPosition.x + rndX, startPosition.y + rndY, startPosition.z + rndZ);

            return newPosition;
        }
    }
}


