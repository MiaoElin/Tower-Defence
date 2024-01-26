using UnityEngine;
public class RoleRntity:MonoBehaviour{
    public int id;
    public int typeID;
    public Ally ally;
    public SpriteRenderer sr;
    public float moveSpeed;
    public Vector2[]path;
    public void Init(Sprite spr){
        sr.sprite=spr;
    }
    public void SetPos(Vector2 pos){
        transform.position=pos;
    }
    public void Move(Vector2 dir,float dt){
        Vector2 pos =transform.position;
        pos+=dir.normalized*moveSpeed*dt;
        transform.position=pos;
    }
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }
}