using System;
using UnityEngine;
public static class UserInterfaceDomain {
    public static void PreTick(GameContext con) {
        //判断是否点了塔位点
        int towerLen = con.towerRepo.TakeAll(out TowerEntity[] all_Tower);
        for (int i = 0; i < towerLen; i++) {
            var tower = all_Tower[i];
            if (con.input.isLeftMouseDown) {
                if (PFPhysics.IsPointInsideRect(con.input.worldMousePos, tower.transform.position, tower.size)) {
                    con.input.isLeftMouseDown = false;
                    UIApp.Panel_BuildTower_Close(con.uicon);
                    UIApp.P_BuildTower_Open(con.uicon, tower.id, tower.transform.position, tower.allowBuildTypeIDs);
                    break;
                } else {
                    if (con.uicon.panel_BuildTower != null) {
                        if(con.input.isLeftMouseDown==false)
                            Debug.Log("inin");
                            UIApp.Panel_BuildTower_Close(con.uicon);
                    }
                }

            }
            // 取消委托，直接可以写做什么
        }
    }
}