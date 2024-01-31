using UnityEngine;
public static class LevelDomain {
    public static LevelEntity SpawnLevel(GameContext con, int level, Difficulty difficulty, ChallengeMode challengeMode) {
        return GameFactory.CreateLevel(con, level, difficulty, challengeMode);
    }
    public static void TrySpawnMonster(GameContext con, LevelEntity level, float dt) {
        level.spawnerComponent.Foreach((Spawner spawner) => {
            for (int i = 0; i < spawner.roleCount; i++) {
                Debug.Log(spawner.roleCount);
                if (!spawner.isSpawn) {
                    return;
                }
                spawner.cd -= dt;
                if (spawner.cd > 0) {
                    return;
                }
                spawner.maintainTimer -= dt;
                spawner.timer -= dt;
                if (spawner.maintainTimer >= 0) {
                    return;
                }
                spawner.maintainTimer = spawner.maintain;
                spawner.cd = spawner.cdMax;
                if (spawner.timer > 0) {
                    return;
                }
                spawner.timer = spawner.interval;

                RoleEntity role = RoleDomain.SpawnRole(con, spawner.roleTypeID, Ally.Monster, spawner.SpawerPos);
                Debug.Log(spawner.SpawerPos);
                level.allRoleID.Add(role.id);
                role.path = level.path;
                if (i == spawner.roleCount - 1) {
                    spawner.isSpawn = false;
                }
            }
        });
    }
    public static void SpawnSite(GameContext con, LevelEntity level) {
        Debug.Log("site");
        Vector2[] sitePos = level.sitesPos;
        foreach (var site in sitePos) {
            TowerDomain.SpawnTower(con, 0, site, Ally.Player);
        }
    }

}