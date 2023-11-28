using UnityEngine;
using UnityEngine.UIElements;

namespace Quirks.UI
{
    public static class UIElementsExtensions
    {
        #region Space

        public static void AddSpace(this VisualElement element)
        {
            var space = new VisualElement();
            space.style.flexGrow = 1;
            element.Add(space);
        }

        public static void AddHSpace(this VisualElement element, float width)
        {
            var space = new VisualElement();
            space.style.width = width;
            element.Add(space);
        }

        public static void AddVSpace(this VisualElement element, float height)
        {
            var space = new VisualElement();
            space.style.height = height;
            element.Add(space);
        }

        #endregion

        #region Margin & Padding

        public static void SetMargin(this IStyle style, float top, float left, float right, float bottom)
        {
            style.marginTop = top;
            style.marginLeft = left;
            style.marginRight = right;
            style.marginBottom = bottom;
        }

        public static void SetMargin(this IStyle style, float margin)
        {
            SetMargin(style, margin, margin, margin, margin);
        }

        public static void SetPadding(this IStyle style, float top, float left, float right, float bottom)
        {
            style.paddingTop = top;
            style.paddingLeft = left;
            style.paddingRight = right;
            style.paddingBottom = bottom;
        }

        public static void SetPadding(this IStyle style, float padding)
        {
            SetPadding(style, padding, padding, padding, padding);
        }

        #endregion

        public static void SetFontSize(this IStyle style, float fontSize, FontStyle fontStyle)
        {
            style.fontSize = fontSize;
            style.unityFontStyleAndWeight = fontStyle;
        }

        public static void TryRemove(this VisualElement element, VisualElement childElement)
        {
            if (element.Contains(childElement))
            {
                element.Remove(childElement);
            }
        }
    }

}
