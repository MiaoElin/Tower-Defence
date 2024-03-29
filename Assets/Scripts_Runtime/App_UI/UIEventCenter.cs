using System;
using UnityEngine;
public class UIEventCenter {
    public event Action Login_OnClickStartHandle;
    public event Action Login_OnClickExitHandle;
    public event Action Login_OnClickSettingHandle;
    public event Action Setting_OnClickCloseHandle;
    public event Action Setting_OnClickMusicHandle;
    public event Action Setting_OnClickSetBoardHandle;
    public event Action Setting_OnClickLangueHandle;
    public event Action Tower_UpskillHandle;
    public event Action<int,int,Vector2> BuildTower;
    public UIEventCenter() {

    }
    public void TearDown() {

    }
    public void Login_Start() { Login_OnClickStartHandle.Invoke(); }
    public void Login_Exit() => Login_OnClickExitHandle();
    public void Login_Setting() => Login_OnClickSettingHandle();
    public void Setting_Close() => Setting_OnClickCloseHandle();
    public void Setting_SetKeyBoard() => Setting_OnClickSetBoardHandle();
    public void Setting_Music() => Setting_OnClickMusicHandle();
    public void Setting_Langue() => Setting_OnClickLangueHandle();
    public void OnClick_UpSkill_Btn() => Tower_UpskillHandle();
    // public void Onclick_Site(int siteEntityID,Vector2 sitePos) => Site_OnClikHandle(siteEntityID,sitePos);


    public void OnClick_BuildTower(int typeID,int siteEntityID,Vector2 towerPos) => BuildTower(typeID,siteEntityID,towerPos);
}