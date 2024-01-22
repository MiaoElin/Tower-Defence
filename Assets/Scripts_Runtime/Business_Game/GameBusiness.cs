using UnityEngine;
public static class GameBusiness {
    public static void EnterGame(GameContext con) {
        GameEntity game = con.gameEntity;
        // 生成波次
        // 生成我方基地
        TowerDomain.SpawnTower(con);
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
    }
    public static void Fixed_Tick() {
        // 
    }
}