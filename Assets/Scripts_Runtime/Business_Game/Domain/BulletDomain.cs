using UnityEngine;
public static class BulletDomain {
    public static BulletEntity SpawnBullet(GameContext con, int bulTypeID, Vector2 pos, Ally ally) {
        BulletEntity bul = GameFactory.CreateBullet(con, con.iDService, bulTypeID, pos, ally);
        con.bulletRepo.Add(bul);
        return bul;
    }
    public static void Move(GameContext con, float dt, BulletEntity bul) {
        // 找到范围内最近的monster，向敌人移动。
        bool has = con.roleRepo.FindNearlyEnemy(bul.transform.position, bul.ally, bul.radius, out RoleEntity nearlyEnemy);
        if (has) {
            bul.LookAt(nearlyEnemy.transform.position);
            Vector2 dir = nearlyEnemy.transform.position - bul.transform.position;
            // if (dir.sqrMagnitude <= 0.01f) {
            //     return;
            // }
            bul.Move(dir.normalized, dt);
            Remove(con,bul, nearlyEnemy);
        }

    }
    public static void Remove(GameContext con, BulletEntity bul, RoleEntity role) {
        if (IntersectHelper.IscircleIntersect(bul.transform.position, bul.size.x, role.transform.position, role.size.x)) {
            role.hp -= bul.lethality;
            if (role.hp <= 0) {
                role.isDead = true;
                con.roleRepo.Remove(role);
                role.TearDown();
            }
            bul.isDead = true;
            con.bulletRepo.Remove(bul);
            bul.TearDown();
        }
    }
}