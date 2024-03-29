using UnityEngine;
[CreateAssetMenu(fileName = "BulletTM_", menuName = "TM/BulletTM")]
public class BulletTM : ScriptableObject {
    public int typeID;
    public Vector2 size;
    public ShapType shapType;
    public float moveSpeed;
    public Sprite sprite;
    // 杀伤力
    public int lethality;
    // 攻击范围
    public float radius;


}