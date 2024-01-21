using UnityEngine;
public static class BusinessFactory{
    public static void CreateTower(GameContext con,int typeID){
        bool has =con.tempCon.TryGet_TowerTM(typeID,out TowerTM tm);
        if(!has){
        Debug.LogError($"Factory.CreateTower: {typeID} not Found");
        return;
        }
        // TowerEntity tower=GameObject.Instantiate()

    }
    public static void CreateHome(){

    }
    public static void CreateRole(){

    }
    public static void CreateBullet(){
        
    }

}