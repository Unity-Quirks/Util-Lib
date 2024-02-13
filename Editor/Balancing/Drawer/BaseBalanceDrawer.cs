using UnityEditor;
using UnityEngine;
using Quirks.Balancing;

namespace Quirks.Editor.Balancing
{
    [CustomPropertyDrawer(typeof(BaseBalance))]
    public class BaseBalanceDrawer : PropertyDrawer
    {
        bool fullFoldout;
        bool extraFoldout;
        bool foldout;
        int testValue;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty type = property.FindPropertyRelative("type");
            float height = EditorGUIUtility.singleLineHeight;
            if (fullFoldout)
            {
                if (extraFoldout)
                {
                    height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("adjustment"));
                    height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("multiplier"));
                    height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("constantMultiplier"));
                }

                height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("levelOffset"));
                height += EditorGUIUtility.singleLineHeight / 3;
                height += EditorGUI.GetPropertyHeight(type);
                height += EditorGUIUtility.singleLineHeight / 3;
                height += EditorGUI.GetPropertyHeight(GetBalanceProperty(property, type.enumValueIndex));

                height += EditorGUIUtility.singleLineHeight * 1.5f;
                if (foldout)
                {
                    height += 8 * EditorGUIUtility.singleLineHeight;
                }
            }
            height += EditorGUIUtility.singleLineHeight * 2;
            return height;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            float offset = 0f;

            EditorGUI.LabelField(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), property.displayName.ToString());
            offset += EditorGUIUtility.singleLineHeight;
            EditorGUI.indentLevel += 1;
            fullFoldout = EditorGUI.Foldout(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), fullFoldout, "Balancing");
            offset += EditorGUIUtility.singleLineHeight;
            if (fullFoldout)
            {
                EditorGUI.indentLevel += 1;
                extraFoldout = EditorGUI.Foldout(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), extraFoldout, "Modifiers");
                offset += EditorGUIUtility.singleLineHeight;
                if (extraFoldout)
                {
                    EditorGUI.indentLevel += 1;

                    DrawerUtil.DrawProperty(position, property, "adjustment", ref offset);
                    DrawerUtil.DrawProperty(position, property, "multiplier", ref offset);
                    DrawerUtil.DrawProperty(position, property, "constantMultiplier", ref offset);

                    EditorGUI.indentLevel -= 1;
                }
                DrawerUtil.DrawProperty(position, property, "levelOffset", ref offset);
                offset += EditorGUIUtility.singleLineHeight / 3;
                SerializedProperty type = property.FindPropertyRelative("type");
                DrawerUtil.DrawProperty(position, property, "type", ref offset);
                offset += EditorGUIUtility.singleLineHeight / 3;
                DrawerUtil.DrawProperty(position, GetBalanceProperty(property, type.enumValueIndex), ref offset);

                EditorGUI.indentLevel += 2;
                foldout = EditorGUI.Foldout(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), foldout, "View Values");
                offset += EditorGUIUtility.singleLineHeight;
                if (foldout)
                {
                    GUIStyle valueStyle = new GUIStyle();
                    valueStyle.padding = new RectOffset(8, 0, 0, 0);
                    valueStyle.richText = true;

                    testValue = EditorGUI.IntField(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), "Input", testValue);
                    offset += EditorGUIUtility.singleLineHeight * 1.5f;
                    if (DrawerUtil.GetTargetObjectOfProperty(property) is BaseBalance fn)
                    {
                        int min = Mathf.Max(1, testValue - 3);
                        for (int i = 0; i < 7; i++)
                        {
                            int index = min + i;
                            double value = fn.GetValue(index);

                            string multiTxt = "";
                            if (fn.Multiplier.HasMultiplier(index) || fn.ConstantMultiplier.HasMultiplier(index))
                                multiTxt = string.Format("(Multi: {0}%)", ((fn.Multiplier.GetMultiplier(index) * fn.ConstantMultiplier.GetMultiplier(index)) * 100f).ToString("0.0"));

                            EditorGUI.LabelField(new Rect(position.x, position.y + offset, position.width, EditorGUIUtility.singleLineHeight), string.Format("<color=white><b>{0}:</b> {1}    {2}</color>", index, value.ToString("0.00"), multiTxt), valueStyle);
                            offset += EditorGUIUtility.singleLineHeight;
                        }
                        offset += EditorGUIUtility.singleLineHeight * 2;
                    }
                }
                EditorGUI.indentLevel -= 2;
                EditorGUI.indentLevel -= 1;
            }

            EditorGUI.indentLevel -= 1;

            EditorGUI.EndProperty();
        }

        SerializedProperty GetBalanceProperty(SerializedProperty property, int enumIndex)
        {
            switch (enumIndex)
            {
                case (int)BaseBalanceType.Linear:
                    return property.FindPropertyRelative("linear");
                case (int)BaseBalanceType.Square:
                    return property.FindPropertyRelative("square");
                case (int)BaseBalanceType.SquareRoot:
                    return property.FindPropertyRelative("squareRoot");
                case (int)BaseBalanceType.Cube:
                    return property.FindPropertyRelative("cube");
                case (int)BaseBalanceType.Exponential:
                    return property.FindPropertyRelative("exponential");
                case (int)BaseBalanceType.ExponentialSin:
                    return property.FindPropertyRelative("exponentialSin");
                case (int)BaseBalanceType.Logarithmic:
                    return property.FindPropertyRelative("logarithmic");
                case (int)BaseBalanceType.Constant:
                    return property.FindPropertyRelative("constant");
                case (int)BaseBalanceType.Quadratic:
                    return property.FindPropertyRelative("quadratic");
                case (int)BaseBalanceType.Cubic:
                    return property.FindPropertyRelative("cubic");
            }

            return property.FindPropertyRelative("_null");
        }
    }
}