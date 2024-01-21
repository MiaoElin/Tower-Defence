using UnityEngine;
public static class GameFactory {
    public static TowerEntity CreateTower(GameContext con, IDService iDService, int typeID,Vector2 pos) {
        bool has = con.tempCon.TryGet_TowerTM(typeID, out TowerTM tm);
        if (!has) {
            Debug.LogError($"Factory.CreateTower: {typeID} not Found");
            return default;
        }
        TowerEntity tower = EntityCreate<TowerEntity>(con);
        tower.typeID = typeID;
        tower.entityID = iDService.TowerIDRecord++;
        tower.SetPos(pos);
        SkillModelTM[] skillModelTMs = tm.skillModelTMs;
        foreach (var skillTM in skillModelTMs) {
            SkillModel skill = new SkillModel();
            skill.typeID = skillTM.typeID;
            skill.SkillLevel = skillTM.SkillLevel;
            skill.skillType = skillTM.skillType;
            SkillLevelTM levelTM = skillTM.skillLevelTMs[skill.SkillLevel - 1];
            skill.sr.sprite = levelTM.sprite;
            skill.cd = 0;
            skill.cdMax = levelTM.cdMax;
            skill.maintain = levelTM.maintain;
            skill.maintainTimer = 0;
            skill.interval=levelTM.interval;
            skill.intervalTimer=0;
            tower.skillModelComponent.Add(skill);
        }
        return tower;
    }
    public static void CreateHome() {

    }
    public static void CreateRole() {

    }
    public static void CreateBullet() {

    }
    public static T EntityCreate<T>(GameContext con) where T : MonoBehaviour {
        string str = typeof(T).Name;
        if (!con.assets.TryGet_Entity(str, out GameObject tm)) {
            Debug.LogError($"Factory.EntityCreate: {str} not Found");
            return default;
        }
        return GameObject.Instantiate(tm, tm.transform).GetComponent<T>();
    }
}