using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
public static class Gamecontroller {
    public static void EnterGame(GameContext con, float dt) {
        GameEntity game = con.gameEntity;
        // 生成等级
        LevelEntity level = LevelDomain.SpawnLevel(con, 1, Difficulty.Easy, ChallengeMode.BattleChallen);
        con.gameEntity.levelID = level.id;
        // 生成地图
        // const string lable = "map";
        // IList<GameObject> all = Addressables.LoadAssetsAsync<GameObject>(lable, null).WaitForCompletion();
        // GameObject.Instantiate(all[0]);
        // 生成我方基地
        // 玩家初始化
        PlayerEntity player = con.playerEntity;
        player.Init(5);
        // 打开Panel_Heart
        UIApp.P_Heart_Open(con.uicon, player.hp);
        game.status = GameStatus.Ingame;
        // 

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
        // 获取当前的关卡
        LevelEntity level = con.TryGetLevel();
        // 生成塔位点
        LevelDomain.SpawnSite(con);
        // 生成HomeEntity
        LevelDomain.SpawnHome(con);
        // 尝试生成角色
        int towerLen = con.towerRepo.TakeAll(out TowerEntity[] all_tower);
        for (int i = 0; i < towerLen; i++) {
            var tower = all_tower[i];
            TowerDomain.TrySpawnRole(con, tower, dt, level);
            bool has = con.roleRepo.FindNearlyEnemy(tower.transform.position, tower.ally, tower.shootRadius, out RoleEntity nearlyEnemy);
            if (has) {
                tower.LookAt(nearlyEnemy.gameObject);
            }
        }
        // 生成monster
        LevelDomain.TrySpawnMonster(con, level, dt);

        //移动角色
        int roleLen = con.roleRepo.TakeAll(out RoleEntity[] all_role);
        for (int i = 0; i < roleLen; i++) {
            var role = all_role[i];
            RoleDomain.Move(con, role, dt);
            RoleDomain.TryShootBul(con, role, dt);
        }
        Debug.Log("bullet has:" + con.tempCon.bulletTMs.Count);
        // 移动子弹
        int bulLen = con.bulletRepo.TakeAll(out BulletEntity[] all_bul);
        for (int i = 0; i < bulLen; i++) {
            var bul = all_bul[i];
            BulletDomain.Move(con, dt, bul);
        }

    }
    public static void Fixed_Tick() {
        // 
    }
}