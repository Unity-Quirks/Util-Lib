using UnityEditor;
using UnityEngine;
using Quirks.Balancing;

namespace Quirks.Editor.Balancing
{
    [CustomPropertyDrawer(typeof(BalanceConstantMultiplier))]
    public class BalanceConstantMultiplierDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var hasOverride = property.FindPropertyRelative("hasConstantMultiplier");
            var height = EditorGUIUtility.singleLineHeight;

            if (hasOverride.boolValue)
            {
                var levelOffset = property.FindPropertyRelative("levelOffset");
                height += EditorGUIUtility.singleLineHeight;

                var levelConstant = property.FindPropertyRelative("levelConstant");
                height += EditorGUIUtility.singleLineHeight;

                var constantMultiplier = property.FindPropertyRelative("constantMultiplier");
                height += EditorGUIUtility.singleLineHeight * 2;
            }

            return height;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var offset = 0f;
            var hasEntriesProp = property.FindPropertyRelative("hasConstantMultiplier");
            hasEntriesProp.boolValue = EditorGUI.ToggleLeft(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), "Has Constant Multiplier", hasEntriesProp.boolValue);

            offset += EditorGUIUtility.singleLineHeight;
            EditorGUI.LabelField(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), "");
            if (hasEntriesProp.boolValue)
            {
                EditorGUI.PropertyField(new Rect(position.x + 8f, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), property.FindPropertyRelative("levelOffset"));
                offset += EditorGUIUtility.singleLineHeight;

                EditorGUI.PropertyField(new Rect(position.x + 8f, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), property.FindPropertyRelative("levelConstant"));
                offset += EditorGUIUtility.singleLineHeight;

                EditorGUI.PropertyField(new Rect(position.x + 8f, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), property.FindPropertyRelative("constantMultiplier"));
                offset += EditorGUIUtility.singleLineHeight * 2;
            }
            EditorGUI.EndProperty();
        }

    }
}