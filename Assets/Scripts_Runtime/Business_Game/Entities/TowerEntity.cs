using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
public class TowerEntity : MonoBehaviour {
    public int id;
    public int typeID;
    public string typeName;
    public int price;
    public Vector2 size;
    public SpriteRenderer sr;
    // ===Spawner===
    public SpawnerComponent spawnerComponent;
    // ===Action===
    public Action OnclickTower;
    public int[] allowBuildTypeIDs;
    public List<int> allRoleID;
    public TowerEntity() {
        allRoleID = new List<int>();
        spawnerComponent = new SpawnerComponent();
    }
    public void Ctor() {

    }
    public void IsClickTower() {
        Vector2 mosePos = Input.mousePosition;
        Vector2 moseWorldPos = Camera.main.ScreenToWorldPoint(mosePos);
        Vector2 pos = transform.position;
        Rect site = new Rect(pos.x - size.x / 2, pos.y - size.y / 2, size.x, size.y);
        if (site.Contains(moseWorldPos)) {
            if (Input.GetMouseButton(0)) {
                OnclickTower.Invoke();
            }
        }
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