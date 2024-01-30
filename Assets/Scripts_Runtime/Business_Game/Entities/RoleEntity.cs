using UnityEngine;
public class RoleEntity : MonoBehaviour {
    public int id;
    public int typeID;
    public Ally ally;
    public SpriteRenderer sr;
    public float moveSpeed;
    // ===path===
    public Vector2[] path;
    public int pathIndex;
    // ===skill===
    public bool isMelee;//是否近战攻击
    public bool hasBullet;//是否发射子弹
    public SkillModelComponent skillModelComponent; //存储各种技能
    // public void Init(Sprite spr) {
    //     sr.sprite = spr;
    // }
    public RoleEntity (){
        skillModelComponent=new SkillModelComponent ();
    }
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
    public void Move(Vector2 dir, float dt) {
        Vector2 pos = transform.position;
        pos += dir.normalized * moveSpeed * dt;
        transform.position = pos;
    }
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }
}