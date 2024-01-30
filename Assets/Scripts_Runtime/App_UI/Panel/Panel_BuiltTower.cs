using UnityEngine.UI;
using UnityEngine;
using System;
using System.Collections.Generic;
public class Panel_BuildTower : MonoBehaviour {
    // public int skillLevelTM_id;
    // public panel_BuildTower_Element prefab;
    public Transform groupTransform;
    public panel_BuildTower_Element prefab;
    List<panel_BuildTower_Element>elements;
    public Action<int> OnClickBuildTower;
    public Panel_BuildTower() {
        elements=new List<panel_BuildTower_Element> ();
    }
    public void AddOpition(int towerTypeID,int price,Sprite sprite){
        panel_BuildTower_Element element=GameObject.Instantiate(prefab,groupTransform);
        element.Ctor(towerTypeID,price,sprite);
        element.btn.onClick.AddListener(()=>{
            OnClickBuildTower.Invoke(element.towerTypeID);
        });
        elements.Add(element);
    }
    public void Ctor() {
        // btn_1.btn.onClick.AddListener(() => {
        //     OnClickBuildTower.Invoke(btn_1.towerTypeID);
        // });
        // btn_2.btn.onClick.AddListener(() => {
        //     OnClickBuildTower.Invoke(btn_2.towerTypeID);
        // });
    }
    public void Show() {
        gameObject.SetActive(true);
    }
    public void Close() {
        gameObject.SetActive(false);
    }
}