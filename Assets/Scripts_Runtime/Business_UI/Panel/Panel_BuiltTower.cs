using UnityEngine.UI;
using UnityEngine;
using System;
public class Panel_BuildTower : MonoBehaviour {
    // public int skillLevelTM_id;
    public Button btn_tower1;
    public Button btn_tower2;
    // public Action<Vector2, int> OnClickBuildTower1Handle;
    // public Action<Vector2, int> OnClickBuildTower2Handle;
    public Action OnClickBuildTower1;
    public Panel_BuildTower() {
    }
    public void Ctor() {
        // Vector2 btnPos = btn_tower1.transform.position;
        // Vector2 towerScreen = new Vector2(btnPos.x - 1, btnPos.y - 1);
        // Vector2 towerPos = Camera.main.ScreenToWorldPoint(towerScreen);
        // btn_tower1.onClick.AddListener(() => {
            
        //     OnClickBuildTower1Handle.Invoke(towerPos, siteEntityID);
        // });
        // btn_tower2.onClick.AddListener(() => {
        //     OnClickBuildTower2Handle.Invoke(towerPos, siteEntityID);
        // });
        btn_tower1.onClick.AddListener(()=>{
            Debug.Log("1");
            OnClickBuildTower1.Invoke();
        });
    }
    public void Show() {
        gameObject.SetActive(true);
    }
    public void Close() {
        gameObject.SetActive(false);
    }
}