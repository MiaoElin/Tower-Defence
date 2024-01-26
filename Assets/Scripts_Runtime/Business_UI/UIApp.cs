using System;
using UnityEngine;
using UnityEngine.EventSystems;
public static class UIApp {
    public static void P_Login_Open(UIcontext uIcon) {
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
        EventSystem.current.SetSelectedGameObject(panel.btn_Star.gameObject);
    }
    public static void P_Login_Close(UIcontext uIcon) {
        Panel_Login panel = uIcon.panel_Login;
        panel.Close();
    }
    public static void P_Setting_Open(UIcontext uIcon) {
        Panel_Setting panel = uIcon.panel_Setting;
        if (panel == null) {
            panel = UIFactory.P_Setting_Create(uIcon);
            panel.Ctor();
            panel.OnCloseClickHandle = () => { uIcon.UIEventCenter.Setting_Close(); };
            panel.OnKeySetClickHandle = () => { uIcon.UIEventCenter.Setting_SetKeyBoard(); };
            panel.OnMusicClickHandle = () => { uIcon.UIEventCenter.Setting_Music(); };
            panel.OnLangueClickHandle = () => { uIcon.UIEventCenter.Setting_Langue(); };
            uIcon.panel_Setting = panel;
        }
        panel.Show();
    }
    public static void P_Setting_Close(UIcontext uIcon) {
        Panel_Setting panel = uIcon.panel_Setting;
        panel.Close();
    }
    public static void P_Heart_Open(UIcontext uiCon, int playerHp) {
        Panel_Heart panel = uiCon.panel_Heart;
        if (panel == null) {
            panel = UIFactory.P_Heart_Create(uiCon);
            uiCon.panel_Heart = panel;
        }
        panel.Init(playerHp);
        panel.Show();
    }
    public static void P_Heart_Update(UIcontext con, int playerHp) {
        Panel_Heart panel = con.panel_Heart;
        panel.Init(playerHp);
    }
    public static void P_Heart_Close(UIcontext con) {
        Panel_Heart panel = con.panel_Heart;
        if (panel != null) {
            panel.Close();
        }
    }
    public static void P_BuildTower_Open(UIcontext con, int thisTowerEntityID, Vector2 thisTowerPos, int[] allowBuidTypeID) {
        Panel_BuildTower panel = con.panel_BuildTower;
        if (panel == null) {
            panel = UIFactory.P_BuildTower_Create(con);
            panel.Ctor();
            con.panel_BuildTower = panel;
        }
        // panel.todo 添加可选项
        if (allowBuidTypeID != null && allowBuidTypeID.Length > 0) {
            foreach (var typeID in allowBuidTypeID) {
                con.tempCon.TryGet_TowerTM(typeID, out TowerTM tM);
                panel.AddOpition(tM.typeID, tM.price, tM.sprite);
            }
        }
        panel.transform.position = thisTowerPos;
        panel.OnClickBuildTower = (int toBuildTowerTypeID) => { con.UIEventCenter.OnClick_BuildTower(toBuildTowerTypeID, thisTowerEntityID, thisTowerPos); };
        panel.Show();

    }
    public static void Panel_BuildTower_Close(UIcontext con) {
        Panel_BuildTower panel = con.panel_BuildTower;
        if (panel != null) {
            GameObject.Destroy(panel.gameObject); //现在panel==null
            
        }
        if (panel == null) {
            // Debug.Log("yes");
        }
    }
}