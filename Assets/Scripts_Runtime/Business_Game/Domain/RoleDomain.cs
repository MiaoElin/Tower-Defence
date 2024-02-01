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
        if (role.path == null || !role.isMoving) {
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
    public static void IsMelee(GameContext con, RoleEntity role, out RoleEntity nearlyEnemy) {
        bool isShoot = con.roleRepo.FindNearlyEnemy(role.transform.position, role.ally, role.shootRadius, out RoleEntity near);
        bool isMelee = con.roleRepo.FindNearlyEnemy(role.transform.position, role.ally, role.meleeRadius, out RoleEntity nearEnemy);
        if (isShoot && !isMelee) {
            Debug.Log("shoot");
            role.isShoot = true;
            role.isMelee = false;
            nearlyEnemy = near;
            return;
        }
        if (isMelee) {
            Debug.Log("melee");
            role.isMelee = true;
            role.isShoot = false;
            nearlyEnemy = nearEnemy;
            return;
        }
        role.isShoot = false;
        role.isMelee = false;
        nearlyEnemy = default;
        return;
    }
    public static void TryShootBul(GameContext con, RoleEntity role, float dt) {
        IsMelee(con, role, out RoleEntity nearlyEnemy);
        role.skillModelComponent.Foreach((SkillModel skill) => {
            skill.cd -= dt;
            if (skill.cd > 0) {
                return;
            }
            skill.maintainTimer -= dt;
            skill.timer -= dt;
            if (skill.maintainTimer >= 0) {
                return;
            }
            skill.maintainTimer = skill.maintain;
            skill.cd = skill.cdMax;
            if (skill.timer > 0) {
                return;
            }
            skill.timer = skill.interval;
            if (skill.skillType == SkillType.Melee) {
                if (role.isMelee) {
                    // todo 近战攻击
                    Debug.Log("不动");
                    role.isMoving = false;
                    nearlyEnemy.isMoving = false;
                    BulletDomain.SpawnBullet(con, skill.bulTypeID, role.transform.position, role.ally);
                }
            }
            if (skill.skillType == SkillType.ShootBullet) {
                if (role.isShoot) {
                    // 生成子弹
                    BulletDomain.SpawnBullet(con, skill.bulTypeID, role.transform.position, role.ally);
                }
            }



        });
    }


}