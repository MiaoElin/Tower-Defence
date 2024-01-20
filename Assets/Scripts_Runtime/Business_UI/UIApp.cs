using System;
using UnityEngine;
using UnityEngine.EventSystems;
public static class UIApp {
    public static void Login_Open(UIcontext uIcon) {
        Panel_Login panel = uIcon.panel_Login;
        if (panel == null) {
            panel = GameObject.Instantiate(uIcon.assetsContext.panel_Login, uIcon.canvas.transform);
            panel.Ctor();
            panel.OnClickStartkHandle = () => { uIcon.UIEventCenter.Login_Start(); };
            panel.OnClickExitHandle = () => { uIcon.UIEventCenter.Login_Exit(); };
            panel.OnClickSettingHandle = () => { uIcon.UIEventCenter.Login_Setting(); };
            uIcon.panel_Login = panel;
        }
        panel.Show();
        EventSystem.current.SetSelectedGameObject(panel.btn_Star.gameObject);
        EventSystem.current.SetSelectedGameObject(panel.btn_Exit.gameObject);
        EventSystem.current.SetSelectedGameObject(panel.btn_Setting.gameObject);
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
            panel=GameObject.Instantiate(uIcon.assetsContext.panel_Setting,uIcon.canvas.transform);
            panel.Ctor();
            panel.OnCloseClickHandle=()=>{uIcon.UIEventCenter.Setting_Close();};
            panel.OnKeySetClickHandle=()=>{uIcon.UIEventCenter.Setting_SetKeyBoard();};
            panel.OnMusicClickHandle=()=>{uIcon.UIEventCenter.Setting_Music();};
            panel.OnLangueClickHandle=()=>{uIcon.UIEventCenter.Setting_Langue();};
            uIcon.panel_Setting=panel;
        }
        panel.Show();
        EventSystem.current.SetSelectedGameObject(panel.btn_Close.gameObject);
        EventSystem.current.SetSelectedGameObject(panel.btn_KeySet.gameObject);
        EventSystem.current.SetSelectedGameObject(panel.btn_Music.gameObject);
        EventSystem.current.SetSelectedGameObject(panel.btn_Language.gameObject);
    }
    public static void Setting_Close(UIcontext uIcon){
        Panel_Setting panel=uIcon.panel_Setting;
        if(panel!=null){
            panel.Close();
        }
    }
}