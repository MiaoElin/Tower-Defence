using UnityEngine;
using System.Collections.Generic;
public static class TowerDomain {
    public static TowerEntity SpawnTower(GameContext con, int typeID, Vector2 pos,Ally ally) {
        TowerEntity tower = GameFactory.CreateTower(con, con.iDService, typeID, pos,ally);
        tower.Ctor();
        // tower.OnclickTower=()=>
        con.towerRepo.Add(tower);
        return tower;
    }
    public static void TrySpawnRole(GameContext con, TowerEntity tower, float dt) {
        List<Spawner> spawners = tower.spawners;
        foreach (var spawner in spawners) {
            if (!spawner.isSpawn) {
                continue;
            }
            Debug.Log("inin");
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
              RoleEntity role=  RoleDomain.SpawnRole(con, spawner.roleTypeID, spawner.ally, tower.transform.position);
                tower.allRoles.Add(role.id);
                spawner.isSpawn=false;
            }
        }
    }
}