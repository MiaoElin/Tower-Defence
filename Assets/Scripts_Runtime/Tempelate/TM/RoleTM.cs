using UnityEngine;
[CreateAssetMenu(fileName ="RoleTM_",menuName ="TM/RoleTM")]
public class RoleTM : ScriptableObject {
    public int typeID;
    public Sprite sprite;
    public float moveSpeed;
    public Vector2[] path;
    public SkillModelTM[] skillModelTMs;
}