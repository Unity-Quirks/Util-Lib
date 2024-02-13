using UnityEditor;
using UnityEngine;
using Quirks.Balancing;

namespace Quirks.Editor.Balancing
{
    [CustomPropertyDrawer(typeof(ExponentialSin))]
    public class ExponentialSinDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = DrawerUtil.GetHeight(property, "baseValue");
            height += DrawerUtil.GetHeight(property, "exponent");
            height += DrawerUtil.GetHeight(property, "sinStep");
            return height;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            EditorGUI.indentLevel += 1;

            float offset = 2f;

            DrawerUtil.DrawProperty(position, property, "baseValue", ref offset);
            DrawerUtil.DrawProperty(position, property, "exponent", ref offset);
            DrawerUtil.DrawProperty(position, property, "sinStep", ref offset);

            EditorGUI.indentLevel -= 1;

            EditorGUI.EndProperty();
        }
    }
}