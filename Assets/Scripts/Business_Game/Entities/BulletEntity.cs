using UnityEngine;
public class BulletEntity : MonoBehaviour {
    public int entityType;
    public int typeID;
    // public Vector2 pos; unity中用transform.position 表示位置，不用自己声明字段
    public Vector2 size;
    public ShapType shapType;
    public float moveSpeed;
    public BulletEntity() {

    }
    public void SetPos(Vector2 pos){
        transform.position=pos;
    }
    public void TearDown(){
        GameObject.Destroy(gameObject);
    }
    public void Move(Vector2 dir,float dt){
        Vector2 pos=transform.position;
        pos+=dir.normalized*dt*moveSpeed;
        transform.position=pos;
    }
}