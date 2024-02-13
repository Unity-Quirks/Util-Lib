using System;
using System.Collections;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Quirks.Editor.Balancing
{
    public static class DrawerUtil
    {
        public static bool DrawProperty(Rect baseRect, SerializedProperty property, string name, ref float offset)
        {
            SerializedProperty prop = property.FindPropertyRelative(name);
            if (prop != null)
            {
                float height = EditorGUI.GetPropertyHeight(prop);
                EditorGUI.PropertyField(new Rect(baseRect.x, baseRect.y + offset, baseRect.width, height), prop);
                offset += height;
            }
            return false;
        }

        public static bool DrawProperty(Rect baseRect, SerializedProperty property, ref float offset)
        {
            if (property != null)
            {
                float height = EditorGUI.GetPropertyHeight(property);
                EditorGUI.PropertyField(new Rect(baseRect.x, baseRect.y + offset, baseRect.width, height), property);
                offset += height;
            }
            return false;
        }

        public static float GetHeight(SerializedProperty property, string name)
        {
            SerializedProperty prop = property.FindPropertyRelative(name);
            if (prop != null)
                return EditorGUI.GetPropertyHeight(prop);

            return 0f;
        }

        public static object GetTargetObjectOfProperty(SerializedProperty property)
        {
            if (property == null) return null;

            string path = property.propertyPath.Replace(".Array.data[", "[");
            object obj = property.serializedObject.targetObject;
            string[] elements = path.Split('.');
            foreach (string element in elements)
            {
                if (element.Contains("["))
                {
                    string elementName = element.Substring(0, element.IndexOf("["));
                    int index = Convert.ToInt32(element.Substring(element.IndexOf("[")).Replace("[", "").Replace("]", ""));
                    obj = GetValue(obj, elementName, index);
                }
                else
                {
                    obj = GetValue(obj, element);
                }
            }
            return obj;
        }

        static object GetValue(object source, string name)
        {
            if (source == null)
                return null;

            Type type = source.GetType();

            while (type != null)
            {
                FieldInfo f = type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                if (f != null)
                    return f.GetValue(source);

                PropertyInfo p = type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (p != null)
                    return p.GetValue(source, null);

                type = type.BaseType;
            }

            return null;
        }

        static object GetValue(object source, string name, int index)
        {
            IEnumerable enumerable = GetValue(source, name) as IEnumerable;
            if (enumerable == null) return null;

            IEnumerator enm = enumerable.GetEnumerator();
            for (int i = 0; i <= index; i++)
            {
                if (!enm.MoveNext()) return null;
            }
            return enm.Current;
        }

    }
}