using UnityEngine;
public class HomeEntity : MonoBehaviour {
    public int entityid;

    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
}