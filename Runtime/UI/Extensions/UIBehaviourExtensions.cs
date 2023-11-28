using TMPro;
using UnityEngine.UI;

namespace Quirks.UI
{
    public static class UIBehaviourExtensions
    {
        public static bool IsFilled(this InputField inputField) => !string.IsNullOrEmpty(inputField.text);
        public static bool IsFilled(this TMP_InputField inputField) => !string.IsNullOrEmpty(inputField.text);
    }

}
