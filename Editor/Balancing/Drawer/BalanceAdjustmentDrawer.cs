using UnityEditor;
using UnityEngine;
using Quirks.Balancing;

namespace Quirks.Editor.Balancing
{
    [CustomPropertyDrawer(typeof(BalanceAdjustment))]
    public class BalanceAdjustmentDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var hasOverride = property.FindPropertyRelative("hasAdjustment");
            var height = EditorGUIUtility.singleLineHeight;

            if (hasOverride.boolValue)
            {
                var levelValues = property.FindPropertyRelative("levelValues");

                int lineCount = 3 + (levelValues.arraySize * 1);
                height += EditorGUIUtility.singleLineHeight * lineCount + EditorGUIUtility.standardVerticalSpacing * (lineCount - 1);
                height += EditorGUIUtility.singleLineHeight;
            }

            return height;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var offset = 0f;
            var hasEntriesProp = property.FindPropertyRelative("hasAdjustment");
            hasEntriesProp.boolValue = EditorGUI.ToggleLeft(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), "Has Adjustments", hasEntriesProp.boolValue);

            offset += EditorGUIUtility.singleLineHeight;
            EditorGUI.LabelField(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), "");
            if (hasEntriesProp.boolValue)
            {
                EditorGUI.PropertyField(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), property.FindPropertyRelative("levelValues"));
            }
            EditorGUI.EndProperty();
        }

    }
}