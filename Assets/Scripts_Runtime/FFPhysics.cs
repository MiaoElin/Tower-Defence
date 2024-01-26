using System;
using UnityEngine;
public static class FFPhysics {
    public static bool IsPointInsideRect(Vector2 pointPos, Vector2 rectPos, Vector2 size) {
        Rect site = new Rect(rectPos.x - size.x / 2, rectPos.y - size.y / 2, size.x, size.y);
        if (site.Contains(pointPos)) {
            return true;
        }
        return false;
    }
}