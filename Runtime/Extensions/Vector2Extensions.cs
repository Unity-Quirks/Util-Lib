using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Quirks
{
    public static class Vector2Extensions
    {
        public static Vector3 ToVector3(this Vector2 vector) => new Vector3(vector.x, vector.y, 0);
    }
}


