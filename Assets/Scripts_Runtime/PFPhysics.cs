using System;
using UnityEngine;
public static class PFPhysics {
    public static bool IsPointInsideRect(Vector2 pointPos, Vector2 rectPos, Vector2 size) {
        Rect site = new Rect(rectPos.x - size.x / 2, rectPos.y - size.y / 2, size.x, size.y);
        if (site.Contains(pointPos)) {
            return true;
        }
        return false;
    }
    public static Vector2 FindPointNearlyPoint(Vector2 pointPos, Vector2[] poss) {
        float neaarlyDistance = float.MaxValue;
        Vector2 nearlyPos=default;
        foreach (var pos in poss) {
           float distance= Vector2.Distance(pointPos,pos);
        if(distance>neaarlyDistance){
            continue;
        }
        neaarlyDistance=distance;
        nearlyPos=pos;
        }
        if(nearlyPos==default){
            Debug.LogError("not found nearlyPos");
        }
        return nearlyPos;
    }
}