using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
public static class Gamecontroller {
    public static void EnterGame(GameContext con) {
        GameEntity game = con.gameEntity;
        // 生成波次
        // 生成地图
        const string lable = "map";
        IList<GameObject> all = Addressables.LoadAssetsAsync<GameObject>(lable, null).WaitForCompletion();
        GameObject.Instantiate(all[0]);
        // 生成我方基地
        // 玩家初始化
        PlayerEntity player = con.playerEntity;
        player.Init(5);
        // 打开Panel_Heart
        UIApp.P_Heart_Open(con.uicon, player.hp);
        // 生成塔位点
        TowerDomain.SpawnTower(con, 0, new Vector2(4.3f, 2.7f));
        TowerDomain.SpawnTower(con, 0, new Vector2(2.35f, -3));
        TowerDomain.SpawnTower(con, 0, new Vector2(-9.7f, -0.2f));
        TowerDomain.SpawnTower(con, 0, new Vector2(-9.8f, 5.6f));
        TowerDomain.SpawnTower(con, 0, new Vector2(6f, 8.2f));
        TowerDomain.SpawnTower(con, 0, new Vector2(0.1f, 8.2f));
        TowerDomain.SpawnTower(con, 0, new Vector2(-1.7f, 2.7f));
        // SiteEntity site1 = GameFactory.CreateSite(con, new Vector2(4.3f, 2.7f));
        // SiteEntity site2 = GameFactory.CreateSite(con, new Vector2(2.35f, -3));
        // SiteEntity site3 = GameFactory.CreateSite(con, new Vector2(-9.7f, -0.2f));
        // SiteEntity site4 = GameFactory.CreateSite(con, new Vector2(-9.8f, 5.6f));
        // SiteEntity site5 = GameFactory.CreateSite(con, new Vector2(6f, 8.2f));
        // SiteEntity site6 = GameFactory.CreateSite(con, new Vector2(0.1f, 8.2f));
        // SiteEntity site7 = GameFactory.CreateSite(con, new Vector2(-1.7f, 2.7f));
        game.status = GameStatus.Ingame;

    }
    public static void Tick(GameContext con) {
        GameEntity game = con.gameEntity;
        // if(game.status==GameStatus.EnterGame){
        //     EnterGame(con);
        // }
        if (game.status == GameStatus.Ingame) {
            Ingame_Tick(con);
        }
        if (game.status == GameStatus.Pause) {

        }

    }
    public static void Ingame_Tick(GameContext con) {
        // 生成tower
        // 每帧加载Panel_Heart
        UIApp.P_Heart_Update(con.uicon, con.playerEntity.hp);
        //判断是否点了塔位点
        int towerLen = con.towerRepo.TakeAll(out TowerEntity[] all_Tower);
        for (int i = 0; i < towerLen; i++) {
            var tower = all_Tower[i];
            if (FFPhysics.IsPointInsideRect(con.input.worldMousePos, tower.transform.position, tower.size)) {
                if (con.input.isLeftMouseDown) {
                    UIApp.Panel_BuildTower_Close(con.uicon);
                    UIApp.P_BuildTower_Open(con.uicon, tower.id, tower.transform.position, tower.allowBuildTypeIDs);
                    break;
                }
            }
            // 取消委托，直接可以写做什么
        }
    }
    public static void Fixed_Tick() {
        // 
    }
}