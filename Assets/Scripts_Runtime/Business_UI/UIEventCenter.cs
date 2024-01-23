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
    public event Action<Vector2> Tower_OnClickHandle;
    public UIEventCenter() {

    }
    public void TearDown() {

    }
    public void Login_Start() {Login_OnClickStartHandle.Invoke();}
    public void Login_Exit() => Login_OnClickExitHandle();
    public void Login_Setting() => Login_OnClickSettingHandle();
    public void Setting_Close() => Setting_OnClickCloseHandle();
    public void Setting_SetKeyBoard() => Setting_OnClickSetBoardHandle();
    public void Setting_Music() => Setting_OnClickMusicHandle();
    public void Setting_Langue()=>Setting_OnClickLangueHandle();
    public void OnClick_Tower(Vector2 pos)=>Tower_OnClickHandle(pos);
}