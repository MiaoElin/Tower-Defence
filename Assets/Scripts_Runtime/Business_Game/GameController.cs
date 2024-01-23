using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
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
        // 生成一座塔
        TowerEntity tower1 = TowerDomain.SpawnTower(con, 0, new Vector2(2.35f, -3));
        TowerEntity tower2 = TowerDomain.SpawnTower(con, 0, new Vector2(4.3f, 2.7f));
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

    }
    public static void Fixed_Tick() {
        // 
    }
}