using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
public static class Gamecontroller {
    public static void EnterGame(GameContext con) {
        GameEntity game = con.gameEntity;
        // 生成等级
        LevelEntity level = LevelDomain.SpawnLevel(con, 1, Difficulty.Easy, ChallengeMode.BattleChallen);
        con.level=level;
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
        TowerDomain.SpawnTower(con, 0, new Vector2(4.3f, 2.7f), Ally.Player);
        TowerDomain.SpawnTower(con, 0, new Vector2(2.35f, -3), Ally.Player);
        TowerDomain.SpawnTower(con, 0, new Vector2(-9.7f, -0.2f), Ally.Player);
        TowerDomain.SpawnTower(con, 0, new Vector2(-9.8f, 5.6f), Ally.Player);
        TowerDomain.SpawnTower(con, 0, new Vector2(6f, 8.2f), Ally.Player);
        TowerDomain.SpawnTower(con, 0, new Vector2(0.1f, 8.2f), Ally.Player);
        TowerDomain.SpawnTower(con, 0, new Vector2(-1.7f, 2.7f), Ally.Player);
        game.status = GameStatus.Ingame;

    }
    public static void Tick(GameContext con, float dt) {
        GameEntity game = con.gameEntity;
        // if(game.status==GameStatus.EnterGame){
        //     EnterGame(con);
        // }
        if (game.status == GameStatus.Ingame) {
            Ingame_Tick(con, dt);
        }
        if (game.status == GameStatus.Pause) {

        }

    }
    public static void Ingame_Tick(GameContext con, float dt) {
        // 生成tower
        // 每帧加载Panel_Heart
        UIApp.P_Heart_Update(con.uicon, con.playerEntity.hp);
        UserInterfaceDomain.PreTick(con);
        // 尝试生成角色
        int towerLen = con.towerRepo.TakeAll(out TowerEntity[] all_tower);
        for (int i = 0; i < towerLen; i++) {
            var tower = all_tower[i];
            TowerDomain.TrySpawnRole(con, tower, dt,con.level);
        }
    }
    public static void Fixed_Tick() {
        // 
    }
}