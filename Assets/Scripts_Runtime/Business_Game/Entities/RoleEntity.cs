using UnityEngine;
public class RoleRntity:MonoBehaviour{
    public int typeID;
    public int id;
    public SpriteRenderer sr;
    public float moveSpeed;
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }
}