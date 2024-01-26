using UnityEngine;
using System.Collections.Generic;
public class HomeEntity : MonoBehaviour {
    public int entityID;
    public SpriteRenderer spr;
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
}