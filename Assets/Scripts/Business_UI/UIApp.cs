using System;
using UnityEngine;
using UnityEngine.EventSystems;
public static class UIApp {
    public static void Login_Open(UIcontext con) {
        Panel_Login panel = con.panel_Login;
        if (panel == null) {
            panel = GameObject.Instantiate(con.assetsContext.panel_Login, con.canvas.transform);
            panel.Ctor();
            panel.OnClickStartkHandle = () => { con.UIEventCenter.Login_Start(); };
            panel.OnClickExitHandle = () => { con.UIEventCenter.Login_Exit(); };
            con.panel_Login = panel;
        }
        panel.Show();
        EventSystem.current.SetSelectedGameObject(panel.btn_Star.gameObject);
    }
    public static void Login_Close(UIcontext con) {
        Panel_Login panel = con.panel_Login;
        if (panel != null) {
            panel.Close();
        }
    }
}