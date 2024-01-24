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
        SiteEntity site1 = GameFactory.CreateSite(con, new Vector2(4.3f, 2.7f));
        SiteEntity site2 = GameFactory.CreateSite(con, new Vector2(2.35f, -3));
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
        int siteLen = con.siteRepo.TakeAll(out SiteEntity[] all_Site);
        for (int i = 0; i < siteLen; i++) {
            var site = all_Site[i];
            site.IsClickSite();
        }
    }
    public static void Fixed_Tick() {
        // 
    }
}