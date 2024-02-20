using UnityEngine;
using UnityEngine.EventSystems;

namespace Quirks
{
    public static class Cursoru
    {
        public static void DeselectCarefully()
        {
            if (!Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
            {
                EventSystem.current.SetSelectedGameObject(null);
            }
        }

        public static bool IsOverUI()
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return true;

            for (int i = 0; i < Input.touchCount; ++i)
                if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
                    return true;

            return GUIUtility.hotControl != 0;
        }
    }
}