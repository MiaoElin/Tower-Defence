using UnityEngine;
public static class TowerDomain {
    public static void SpawnTower(GameContext con) {
        TowerEntity tower = GameFactory.CreateTower(con, con.iDService, 1, new Vector2(0, 0));
        SkillModel currentSkill = tower.skillModelComponent.TryGetCurrent();
        Debug.Log(currentSkill.sprite);
        tower.sr.sprite=currentSkill.sprite;
        con.towerRepo.Add(tower);
    }
}