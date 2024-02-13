using UnityEditor;
using UnityEngine;
using Quirks.Balancing;

namespace Quirks.Editor.Balancing
{
    [CustomPropertyDrawer(typeof(Exponential))]
    public class ExponentialDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var height = DrawerUtil.GetHeight(property, "baseValue");
            height += DrawerUtil.GetHeight(property, "exponent");
            return height;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            EditorGUI.indentLevel += 1;

            float offset = 2f;

            DrawerUtil.DrawProperty(position, property, "baseValue", ref offset);
            DrawerUtil.DrawProperty(position, property, "exponent", ref offset);

            EditorGUI.indentLevel -= 1;

            EditorGUI.EndProperty();
        }
    }
}