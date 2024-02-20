using System.Collections.Generic;
using UnityEngine;

namespace Quirks
{
    public static class Transformu
    {
        /// <summary>Returns the closest transform from a list</summary>
        /// <param name="transforms">List of Transforms</param>
        /// <param name="location">Location to determine distance from Transform</param>
        public static Transform GetNearestTransform(IList<Transform> transforms, Vector2 location)
        {
            Transform closest = null;
            foreach (Transform target in transforms)
            {
                if (closest == null || Vector2.Distance(target.position, location) < Vector2.Distance(closest.position, location)) closest = target;
            }
            return closest;
        }

        /// <summary>Returns the closest transform from a list</summary>
        /// <param name="transforms">List of Transforms</param>
        /// <param name="location">Location to determine distance from Transform</param>
        public static Transform GetNearestTransform(IList<Transform> transforms, Vector3 location)
        {
            Transform closest = null;
            foreach (Transform target in transforms)
            {
                if (closest == null || Vector3.Distance(target.position, location) < Vector3.Distance(closest.position, location)) closest = target;
            }
            return closest;
        }

        public static float GetClosestDistance(Transform a, Transform b)
        {
            float distance = Vector3.Distance(a.transform.position, b.gameObject.transform.position);

            float radiusA = BoundsRadius(a.GetComponent<Collider>().bounds);
            float radiusB = BoundsRadius(b.GetComponent<Collider>().bounds);

            float distanceInside = distance - radiusA - radiusB;

            return Mathf.Max(distanceInside, 0);
        }

        public static float BoundsRadius(Bounds bounds) => (bounds.extents.x + bounds.extents.z) / 2;
    }

}
