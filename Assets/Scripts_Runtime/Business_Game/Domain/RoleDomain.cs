using UnityEngine;
public static class RoleDomain{
    public static RoleEntity  SpawnRole(GameContext con,int typeID,Ally ally, Vector2 pos){
        RoleEntity role=GameFactory.CreateRole(con,con.iDService,typeID,ally,pos);
        con.roleRepo.Add(role);
        return role;
    }
}