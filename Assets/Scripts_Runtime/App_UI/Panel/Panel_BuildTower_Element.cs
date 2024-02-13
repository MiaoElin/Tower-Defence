using UnityEngine;
using UnityEngine.UI;
using System;
public class panel_BuildTower_Element : MonoBehaviour {
    public int towerTypeID;
    // public int towerSkillLevel;
    public Text price;
    public Image icon;
    public Button btn;
    // public Action<int,int> OnClickHandle;
    // public void Ctor(){
    //     btn.onClick.AddListener(()=>{
    //         OnClickHandle.Invoke(towerTypeID,towerSkillLevel);
    //     });
    // }
    public void Ctor(int towerTypeID, int price, Sprite sprite) {
        this.towerTypeID = towerTypeID;
        if (towerTypeID != 0) {
            this.price.text = price.ToString();
            this.icon.sprite = sprite;
        }
    }
}