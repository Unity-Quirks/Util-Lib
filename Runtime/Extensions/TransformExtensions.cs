using System.Collections.Generic;
using UnityEngine;

namespace Quirks
{
    public static class TransformExtensions
    {
        #region Set X Y Z

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

        public static void SetLocalX(this Transform transform, float value)
        {
            transform.localPosition = new Vector3(value, transform.localPosition.y, transform.localPosition.z);
        }
        public static void SetLocalY(this Transform transform, float value)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, value, transform.localPosition.z);
        }
        public static void SetLocalZ(this Transform transform, float value)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, value);
        }

        #endregion

        public static void Reset(this Transform transform)
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        public static void ResetLocal(this Transform transform)
        {
            transform.localScale = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        #region Children

        public static void SetActiveChildren(this Transform transform, bool active)
        {
            foreach (Transform child in transform)
                child.gameObject.SetActive(active);
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

        /// <summary>Balances the number of child GameObjects under a specified parent.</summary>
        /// <param name="parent">Parent which holds the prefabs.</param>
        /// <param name="prefab">The prefab to instaniate.</param>
        /// <param name="amount">Desired amount of GameObjects.</param>
        public static void BalancePrefabs(this Transform parent, GameObject prefab, int amount)
        {
            for (int i = parent.childCount; i < amount; ++i)
            {
                GameObject go = GameObject.Instantiate(prefab);
                go.transform.SetParent(parent, false);
            }

            for (int i = parent.childCount - 1; i >= amount; --i)
                GameObject.Destroy(parent.GetChild(i).gameObject);
        }

        public static void DetachChildren(this Transform transform)
        {
            while(transform.childCount > 0)
            {
                transform.GetChild(0).SetParent(null);
            }
        }

        public static Transform FindChildWithTag(this Transform transform, string tag)
        {
            foreach(Transform child in transform)
            {
                if (child.CompareTag(tag))
                    return child;
            }

            return null;
        }

        public static void Clear(this Transform transform)
        {
            foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }

        public static void ClearImmediate(this Transform transform)
        {
            while(transform.childCount > 0)
            {
                GameObject.DestroyImmediate(transform.GetChild(0).gameObject);
            }
        }

        #endregion

        #region Translation

        public static void LerpTowards(this Transform transform, Vector3 targetPosition, float speed)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        }
        public static void LerpTowards(this Transform transform, Transform targetPosition, float speed)
        {
            LerpTowards(transform, targetPosition.position, speed);
        }

        #endregion



        public static void SetLayerRecursively(this Transform transform, int layer)
        {
            transform.gameObject.layer = layer;
            foreach (Transform child in transform)
                child.SetLayerRecursively(layer);
        }

        public static void SetLayerRecursively(this Transform transform, string layerName)
        {
            int layer = LayerMask.NameToLayer(layerName);
            if (layer != -1)
                transform.SetLayerRecursively(layer);
        }
    }
}


