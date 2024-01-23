using UnityEngine;
using System;
using UnityEngine.UI;
public class TowerEntity : MonoBehaviour {
    public int entityID;
    public int typeID;
    public SpriteRenderer sr;
    // ===skill===
    public SkillModelComponent skillModelComponent;
    // ===Action===
    public Action OnclickTower;
    // ===Button===
    public Button btn_Tower;
    public TowerEntity() {
        skillModelComponent = new SkillModelComponent();
    }
    public void Ctor() {
        btn_Tower.onClick.AddListener(() => {
            OnclickTower.Invoke();
        });
    }
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }

}