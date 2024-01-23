using UnityEngine.UI;
using UnityEngine;
using System;
public class Panel_BuildTower : MonoBehaviour {
    // public int skillLevelTM_id;
    public int typeID;// 每种skillLevelTM都对应了一个建塔的页面；
    public Button[] btn_TMs;
    public Action OnClickUpSkillHandle;
    public Panel_BuildTower() {
        // btn_TMs[0].transform.position=new Vector2(transform.position.x-1,transform.position.y+1);
    }
    public void Ctor() {
        // 每个按钮都绑定升级的事件
        foreach (var btn in btn_TMs) {
            btn.onClick.AddListener(() => {
                OnClickUpSkillHandle.Invoke();
            });
        }
    }
    public void Show() {
        gameObject.SetActive(true);
    }
    public void Close() {
        gameObject.SetActive(false);
    }
}