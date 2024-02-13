using UnityEditor;
using UnityEngine;
using Quirks.Balancing;

namespace Quirks.Editor.Balancing
{
    [CustomPropertyDrawer(typeof(LevelValue))]
    public class LevelValueDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            float width = (position.width * 0.5f) - 10f;

            SerializedProperty levelProp = property.FindPropertyRelative("level");
            levelProp.intValue = EditorGUI.IntField(new Rect(position.x, position.y, width, position.height), levelProp.intValue);

            SerializedProperty valueProp = property.FindPropertyRelative("value");
            valueProp.doubleValue = EditorGUI.DoubleField(new Rect(position.x + 10 + width, position.y, width, position.height), valueProp.doubleValue);
        }
    }
}