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
    public void LookAt(GameObject target) {
        Vector2 dir = target.transform.position - transform.position;
        var angel = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;// 向量转了多少弧度
        var trailRotation = Quaternion.AngleAxis(angel, Vector3.back);
        transform.rotation = trailRotation;
    }
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }

}