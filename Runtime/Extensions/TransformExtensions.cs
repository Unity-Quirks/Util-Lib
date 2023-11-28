using System.Collections.Generic;
using UnityEngine;

namespace Quirks
{
    public static class TransformExtensions
    {
        public static void SetX(this Transform transform, float value)
        {
            transform.position = new Vector3(value, transform.position.y, transform.position.z);
        }
        public static void SetY(this Transform transform, float value)
        {
            transform.position = new Vector3(transform.position.x, value, transform.position.z);
        }
        public static void SetZ(this Transform transform, float value)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, value);
        }

        public static void Reset(this Transform transform)
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        public static Transform[] GetChildren(this Transform transform)
        {
            Transform[] children = new Transform[transform.childCount];
            for (int i = 0; i < transform.childCount; i++)
            {
                children[i] = transform.GetChild(i);
            }

            return children;
        }
        public static List<Transform> GetDescendants(this Transform transform)
        {
            List<Transform> descendants = new List<Transform>();
            foreach (Transform child in transform)
            {
                descendants.Add(child);
                descendants.AddRange(child.GetDescendants());
            }

            return descendants;
        }

        public static void Clear(this Transform transform)
        {
            foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }

        public static void LerpTowards(this Transform transform, Vector3 targetPosition, float speed)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        }
        public static void LerpTowards(this Transform transform, Transform targetPosition, float speed)
        {
            LerpTowards(transform, targetPosition.position, speed);
        }
    }
}


