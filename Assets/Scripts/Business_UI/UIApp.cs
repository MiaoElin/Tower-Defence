using System;
using UnityEngine;
public static class UIApp{
    public static void Login_Open(UIcontext con,Action OnClicStartkHandle){
        Panel_Login panel=con.panel_Login;
        if(panel==null){
            panel.Ctor();
            panel.OnClicStartkHandle=OnClicStartkHandle;
            panel=GameObject.Instantiate(con.panel_Login,con.canvas.transform);
            con.panel_Login=panel;
        }
        panel.Show();
    }
    public static void Login_Close(UIcontext con){
        Panel_Login panel=con.panel_Login;
        if(panel!=null){
            panel.Close();
        }
    }
}