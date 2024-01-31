using UnityEngine;
public static class RoleDomain {
    public static RoleEntity SpawnRole(GameContext con, int typeID, Ally ally, Vector2 pos) {
        RoleEntity role = GameFactory.CreateRole(con, con.iDService, typeID, ally, pos);
        con.roleRepo.Add(role);
        return role;
    }
    // public static void GetRolePath(GameContext con, RoleEntity role,LevelEntity level) {
    //     if(role.ally==Ally.Monster){
    //         role.path=level.path;
    //     }
    // }
    public static void Move(GameContext con, RoleEntity role, float dt) {
        if (role.path == null) {
            return;
        }
        if (role.pathIndex == role.path.Length) {
            return;
        }
        Vector2 target = role.path[role.pathIndex];
        Vector2 dir = target - (Vector2)role.transform.position;
        if (dir.sqrMagnitude <= 0.01f) {
            role.pathIndex += 1;
        } else {
            role.Move(dir.normalized, dt);
        }

    }

}