using UnityEngine;
public class BulletEntity : MonoBehaviour {
    public int id;
    public Ally ally;
    public int typeID;
    // public Vector2 pos; unity中用transform.position 表示位置，不用自己声明字段
    public Vector2 size;
    public ShapType shapType;
    public SpriteRenderer sr;
    public float moveSpeed;
    // 朝向
    public Vector2 dir;
    // 攻击范围
    public float radius;
    public int lethality;
    public Vector2 []path;
    public bool isDead;
    public Vector2 lastDir;
    public BulletEntity() {

    }
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }
    public void LookAt(Vector2 target) {
        Vector2 dir = target - (Vector2)transform.position;
        var angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.back);
    }
    public void Move(Vector2 dir, float dt) {
        Vector2 pos = transform.position;
        pos += dir.normalized * dt * moveSpeed;
        transform.position = pos;
    }
}