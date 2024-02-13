using UnityEditor;
using UnityEngine;
using Quirks.Balancing;

namespace Quirks.Editor.Balancing
{
    [CustomPropertyDrawer(typeof(Quadratic))]
    public class QuadraticDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = DrawerUtil.GetHeight(property, "baseValue");
            height += DrawerUtil.GetHeight(property, "b");
            height += DrawerUtil.GetHeight(property, "c");
            return height;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            EditorGUI.indentLevel += 1;

            float offset = 2f;

            DrawerUtil.DrawProperty(position, property, "baseValue", ref offset);
            DrawerUtil.DrawProperty(position, property, "b", ref offset);
            DrawerUtil.DrawProperty(position, property, "c", ref offset);

            EditorGUI.indentLevel -= 1;

            EditorGUI.EndProperty();
        }
    }
}