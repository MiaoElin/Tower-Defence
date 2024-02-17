using System.Collections.Generic;
using UnityEngine;
public class RoleRepo {
    Dictionary<int, RoleEntity> all;
    RoleEntity[] tempAarry;
    public RoleRepo() {
        all = new Dictionary<int, RoleEntity>();
        tempAarry = new RoleEntity[100];
    }
    public void Add(RoleEntity role) {
        all.Add(role.id, role);
    }
    public void Remove() {
        int roleLen=TakeAll(out RoleEntity []all_role);
        for(int i=0;i<roleLen;i++){
            var role=all_role[i];
            if(role.isDead){
                all.Remove(role.id);
                role.TearDown();
            }
        }
        
    }
    public void Remove(int roleID) {
        all.Remove(roleID);
    }
    public bool TryGet_role(int id, out RoleEntity role) {
        return all.TryGetValue(id, out role);
    }
    public bool FindNearlyEnemy(Vector2 pos, Ally ally, float radius, out RoleEntity nearlyMonster) {
        int roleLen = TakeAll(out RoleEntity[] all_role);
        RoleEntity nearMonster = default;
        float neaarlyDistance = radius * radius;
        for (int i = 0; i < roleLen; i++) {
            var ro = all_role[i];
            if (ro.ally != ally) {
                Vector2 dir = (Vector2)ro.transform.position - pos;
                float Distance = dir.sqrMagnitude;
                if (Distance <= neaarlyDistance) {
                    neaarlyDistance = Distance;
                    nearMonster = ro;
                }
            }
        }
        nearlyMonster = nearMonster;
        if (nearMonster != default) {
            return true;
        }
        return false;
    }
    public int TakeAll(out RoleEntity[] all_role) {
        if (all.Count > tempAarry.Length) {
            tempAarry = new RoleEntity[all.Count];
        }
        all.Values.CopyTo(tempAarry, 0);
        all_role = tempAarry;
        return all.Count;
    }
}