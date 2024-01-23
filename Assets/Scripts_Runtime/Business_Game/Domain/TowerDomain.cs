using UnityEngine;
public static class TowerDomain {
    public static TowerEntity  SpawnTower(GameContext con,int typeID,Vector2 pos) {
        TowerEntity tower = GameFactory.CreateTower(con, con.iDService, typeID, pos);
        SkillModel currentSkill = tower.skillModelComponent.TryGetCurrent();
        // Debug.Log(currentSkill.sprite);
        tower.sr.sprite = currentSkill.sprite;
        tower.Ctor();
        tower.OnclickTower=()=>{con.uicon.UIEventCenter.OnClick_Tower(tower);};
        con.towerRepo.Add(tower);
        return tower;
    }
}