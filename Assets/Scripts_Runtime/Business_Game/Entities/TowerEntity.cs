using UnityEngine;
public class TowerEntity:MonoBehaviour{
    public int entityid;
    public int typeID;
    // ====skill====
    public SkillModelComponent skillModelComponent;
    public int SkillLevel;

    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
    public void TearDown(){
        GameObject.Destroy(gameObject);
    }
}