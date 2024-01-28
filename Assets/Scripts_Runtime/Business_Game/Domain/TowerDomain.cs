using UnityEngine;
using System.Collections.Generic;
public static class TowerDomain {
    public static TowerEntity SpawnTower(GameContext con, int typeID, Vector2 pos) {
        TowerEntity tower = GameFactory.CreateTower(con, con.iDService, typeID, pos);
        tower.Ctor();
        // tower.OnclickTower=()=>
        con.towerRepo.Add(tower);
        return tower;
    }
    public static void TrySpawnRole(GameContext con, TowerEntity tower, float dt) {
        List<SpawnerTM> spawnerTMs = tower.spawnerTMs;
        foreach (var spawner in spawnerTMs) {
            if (!spawner) {
                continue;
            }
            spawner.cd -= dt;
            if (spawner.cd > 0) {
                continue;
            }
            spawner.maintainTimer -= dt;
            spawner.timer -= dt;
            if (spawner.maintainTimer >= 0) {
                continue;
            }
            spawner.maintainTimer = spawner.maintain;
            spawner.cd = spawner.cdMax;
            if (spawner.timer > 0) {
                continue;
            }
            spawner.timer = spawner.interval;
            for (int i = 0; i < spawner.roleCount; i++) {
                RoleDomain.SpawnRole(con, spawner.roleTypeID, spawner.ally, tower.transform.position);
            }
        }
    }
}