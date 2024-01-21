using System;
using UnityEngine;
using UnityEngine.EventSystems;
public static class UIApp {
    public static void Login_Open(UIcontext uIcon) {
        Panel_Login panel = uIcon.panel_Login;
        if (panel == null) {
            panel = UIFactory.P_Login_Create(uIcon);
            panel.Ctor();
            panel.OnClickStartkHandle = () => { uIcon.UIEventCenter.Login_Start(); };
            panel.OnClickExitHandle = () => { uIcon.UIEventCenter.Login_Exit(); };
            panel.OnClickSettingHandle = () => { uIcon.UIEventCenter.Login_Setting(); };
            uIcon.panel_Login = panel;
        }
        panel.Show();
        // EventSystem.current.SetSelectedGameObject(panel.btn_Star.gameObject);
    }
    public static void Login_Close(UIcontext uIcon) {
        Panel_Login panel = uIcon.panel_Login;
        if (panel != null) {
            panel.Close();
        }
    }
    public static void Setting_Open(UIcontext uIcon){
        Panel_Setting panel=uIcon.panel_Setting;
        if(panel==null){
            panel=UIFactory.P_Setting_Create(uIcon);
            panel.Ctor();
            panel.OnCloseClickHandle=()=>{uIcon.UIEventCenter.Setting_Close();};
            panel.OnKeySetClickHandle=()=>{uIcon.UIEventCenter.Setting_SetKeyBoard();};
            panel.OnMusicClickHandle=()=>{uIcon.UIEventCenter.Setting_Music();};
            panel.OnLangueClickHandle=()=>{uIcon.UIEventCenter.Setting_Langue();};
            uIcon.panel_Setting=panel;
        }
        panel.Show();
    }
    public static void Setting_Close(UIcontext uIcon){
        Panel_Setting panel=uIcon.panel_Setting;
        if(panel!=null){
            panel.Close();
        }
    }
}