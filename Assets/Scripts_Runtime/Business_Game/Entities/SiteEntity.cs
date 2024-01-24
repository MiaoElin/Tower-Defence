using System;
using UnityEngine.UI;
using UnityEngine;
public class SiteEntity : MonoBehaviour {
    public int id;
    public Vector2 size;
    public Action OnSiteClickHandle;

    public SiteEntity() {

    }
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
    public void IsClickSite() {
        Vector2 mosePos = Input.mousePosition;
        Vector2 moseWorldPos = Camera.main.ScreenToWorldPoint(mosePos);
        Vector2 pos = transform.position;
        Rect site = new Rect(pos.x - size.x / 2, pos.y - size.y / 2, size.x, size.y);
        if (site.Contains(moseWorldPos)) {
            if (Input.GetMouseButton(0)) {
                OnSiteClickHandle.Invoke();
            }
        }
    }
    public void Ctor() {

    }

}