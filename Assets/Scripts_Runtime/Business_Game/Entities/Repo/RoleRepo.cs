using System.Collections.Generic;
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
    public void Remove(RoleEntity role) {
        all.Remove(role.id);
    }
    public void Remove(int roleID) {
        all.Remove(roleID);
    }
    public bool TryGet_role(int id, out RoleEntity role) {
        return all.TryGetValue(id, out role);
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