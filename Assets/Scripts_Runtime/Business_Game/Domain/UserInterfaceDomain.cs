using System;
using UnityEngine;
using System.Collections.Generic;
public static class UserInterfaceDomain {
    public static void PreTick(GameContext con) {
        Panel_BuildTower panel = con.uicon.panel_BuildTower;
        // 判断是否点了建塔按钮
        if (con.uicon.panel_BuildTower != null) {
            Debug.Log(con.uicon.panel_BuildTower.isNoneButtonDown);
            if (con.uicon.panel_BuildTower.isNoneButtonDown == true) {
                UIApp.Panel_BuildTower_Close(con.uicon);
            }
        }
        //判断是否点了塔位点
        int towerLen = con.towerRepo.TakeAll(out TowerEntity[] all_Tower);
        for (int i = 0; i < towerLen; i++) {
            var tower = all_Tower[i];
            if (con.input.isLeftMouseDown) {
                if (PFPhysics.IsPointInsideRect(con.input.worldMousePos, tower.transform.position, tower.size)) {
                    UIApp.Panel_BuildTower_Close(con.uicon);
                    UIApp.P_BuildTower_Open(con.uicon, tower.id, tower.transform.position, tower.allowBuildTypeIDs);
                    break;
                } else {
                    if (panel != null) {
                        List<panel_BuildTower_Element> elements = panel.elements;
                        bool isfound = default;
                        foreach (var element in elements) {
                            element.isButtonDown = false;
                            if (PFPhysics.IsPointInsideRect(con.input.worldMousePos, element.transform.position, element.size)) {
                                element.isButtonDown = true;
                                isfound = true;
                            }
                        }
                        if (isfound == default) {
                            panel.isNoneButtonDown = true;
                        }
                    }
                }
            }
            // 取消委托，直接可以写做什么
        }
    }
}
