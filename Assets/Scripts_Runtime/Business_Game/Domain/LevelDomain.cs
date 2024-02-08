using UnityEngine;
public static class LevelDomain {
    public static LevelEntity SpawnLevel(GameContext con, int typeID, Difficulty difficulty, ChallengeMode challengeMode) {
        LevelEntity level = GameFactory.CreateLevel(con, typeID, difficulty, challengeMode);
        con.levelRepo.Add(level);
        return level;
    }
    public static void TrySpawnMonster(GameContext con, LevelEntity level, float dt) {
        level.spawnerComponent.Foreach((Spawner spawner) => {

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
            level.allMonsterID.Add(role.id);
            role.path = level.path;
            if (level.allMonsterID.Count == spawner.roleCount) {
                spawner.isSpawn = false;
            }

        });
    }
    public static void SpawnSite(GameContext con) {
        LevelEntity level = con.TryGetLevel();
        Vector2[] sitePos = level.sitesPos;
        if (level.sitePosCount > sitePos.Length) {
            return;
        }
        foreach (var site in sitePos) {
            TowerDomain.SpawnTower(con, 0, site, Ally.Player);
            level.sitePosCount += 1;
        }
    }
    public static void SpawnHome(GameContext con) {
        LevelEntity level = con.TryGetLevel();
        Vector2[] homes = level.homeEntities;
        int homeLen = con.homeRepo.TakeAll(out HomeEntity[] all);
        if (homeLen == homes.Length) {
            return;
        }
        foreach (var home in homes) {
            HomeEntity ho = GameFactory.CreateHome(con, home);
            con.homeRepo.Add(ho);
        }
    }

}