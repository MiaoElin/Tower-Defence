using UnityEngine.UI;
using UnityEngine;
using System;
public class Panel_BuildTower : MonoBehaviour {
    // public int skillLevelTM_id;
    public Button btn_tower1;
    public Button btn_tower2;
    public Action<Vector2, int> OnClickBuildTower1Handle;
    public Action<Vector2, int> OnClickBuildTower2Handle;
    public Panel_BuildTower() {
        // btn_TMs[0].transform.position=new Vector2(transform.position.x-1,transform.position.y+1);
    }
    public void Ctor(int siteEntityID) {
        // 每个按钮都绑定升级的事件
        // for (int i = 0; i < btn_TMs.Length; i++) {
        //     var btn = btn_TMs[i];
        //     btn.onClick.AddListener(() => {
        //         OnClickBuildTowerHandle.Invoke(i);
        //     });
        // }
        Vector2 btnPos = btn_tower1.transform.position;
        Vector2 towerScreen = new Vector2(btnPos.x - 1, btnPos.y - 1);
        Vector2 towerPos = Camera.main.ScreenToWorldPoint(towerScreen);
        btn_tower1.onClick.AddListener(() => {
            
            OnClickBuildTower1Handle.Invoke(towerPos, siteEntityID);
        });
        btn_tower2.onClick.AddListener(() => {
            OnClickBuildTower2Handle.Invoke(towerPos, siteEntityID);
        });
    }
    public void Show() {
        gameObject.SetActive(true);
    }
    public void Close() {
        gameObject.SetActive(false);
    }
}