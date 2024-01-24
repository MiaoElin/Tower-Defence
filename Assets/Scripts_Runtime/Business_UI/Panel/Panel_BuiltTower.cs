using UnityEngine.UI;
using UnityEngine;
using System;
using System.Collections.Generic;
public class Panel_BuildTower : MonoBehaviour {
    // public int skillLevelTM_id;
    // public panel_BuildTower_Element prefab;
    public panel_BuildTower_Element btn_1;
    public panel_BuildTower_Element btn_2;
    public Action<int> OnClickBuildTower;
    public Panel_BuildTower() {
    }
    public void Ctor() {
        btn_1.btn.onClick.AddListener(() => {
            OnClickBuildTower.Invoke(btn_1.towerTypeID);
        });
        btn_2.btn.onClick.AddListener(() => {
            OnClickBuildTower.Invoke(btn_2.towerTypeID);
        });
    }
    public void Show() {
        gameObject.SetActive(true);
    }
    public void Close() {
        gameObject.SetActive(false);
    }
}