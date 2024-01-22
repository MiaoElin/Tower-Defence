using UnityEngine;
public class TowerEntity : MonoBehaviour {
    public int entityID;
    public int typeID;
    public SpriteRenderer sr;
    // ====skill====
    public SkillModelComponent skillModelComponent;
    public TowerEntity() {
        skillModelComponent = new SkillModelComponent();
    }
    public void Init(){

    }
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }

}