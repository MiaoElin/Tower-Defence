using UnityEngine;
public static class TowerDomain {
    public static TowerEntity SpawnTower(GameContext con, int typeID, Vector2 pos) {
        TowerEntity tower = GameFactory.CreateTower(con, con.iDService, typeID, pos);
        tower.Ctor();
        // tower.OnclickTower=()=>
        con.towerRepo.Add(tower);
        return tower;
    }
}