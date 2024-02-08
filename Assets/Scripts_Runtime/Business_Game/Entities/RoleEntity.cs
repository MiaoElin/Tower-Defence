using UnityEngine;
using UnityEngine.UI;
public class RoleEntity : MonoBehaviour {
    public int id;
    public int typeID;
    public Ally ally;
    public Vector2 size;
    public int hp;
    public int hpmax;
    public Image hpImage;
    public SpriteRenderer sr;
    public float moveSpeed;
    // ===path===
    public bool isMoving;
    public Vector2[] path;
    public int pathIndex;
    // ===skill===
    public bool isMelee;//是否近战攻击
    public bool isShoot;//是否发射子弹
    public float shootRadius;
    public float meleeRadius;
    public SkillModelComponent skillModelComponent; //存储各种技能
    // public void Init(Sprite spr) {
    //     sr.sprite = spr;
    // }
    public bool isDead;
    public RoleEntity() {
        skillModelComponent = new SkillModelComponent();
        //  Canvas screenCanvas = gameObject.transform.Find("ScreenCanvas").GetComponent<Canvas>(); 
    }
    public void Init() {
    }
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
    public void SetHp(){
        hpImage.GetComponent<RectTransform>().sizeDelta=new Vector2 (hp*0.7f/hpmax,0.1f);
    }
    public void Move(Vector2 dir, float dt) {
        Vector2 pos = transform.position;
        pos += dir.normalized * moveSpeed * dt;
        transform.position = pos;
        // panel_Hp_Element=GameObject.Instantiate(prefab,transform);
        // panel_Hp_Element.transform.position = new Vector2(pos.x, pos.y + 0.7f);
    }
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }
}