using System;
public static class UserInterfaceDomain {
    public static void PreTick(GameContext con) {
        //判断是否点了塔位点
        int towerLen = con.towerRepo.TakeAll(out TowerEntity[] all_Tower);
        for (int i = 0; i < towerLen; i++) {
            var tower = all_Tower[i];
            if (PFPhysics.IsPointInsideRect(con.input.worldMousePos, tower.transform.position, tower.size)) {
                if (con.input.isLeftMouseDown) {
                    UIApp.Panel_BuildTower_Close(con.uicon);
                    UIApp.P_BuildTower_Open(con.uicon, tower.id, tower.transform.position, tower.allowBuildTypeIDs);
                    break;
                }
            }
            // 取消委托，直接可以写做什么
        }
    }
}