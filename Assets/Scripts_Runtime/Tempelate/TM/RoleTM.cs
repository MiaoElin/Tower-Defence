using UnityEngine;
[CreateAssetMenu(fileName = "RoleTM_", menuName = "TM/RoleTM")]
public class RoleTM : ScriptableObject {
    public int typeID;
    public int hp;
    public Sprite sprite;
    public Vector2 size;
    public float moveSpeed;
    public Vector2[] path;
    public int pathIndex;
    public float meleeRadius;
    public float shootRadius;
    public SkillModelTM[] skillModelTMs;
}