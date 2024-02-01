using System.Collections.Generic;
public class TempelateContext {
    Dictionary<int, TowerTM> towerTMs;
    Dictionary<int, SkillModelTM> skillModelTMs;
    // Dictionary<int, SkillLevelTM> skillLevelTMs;
    Dictionary<int, RoleTM> roleTMs;
    Dictionary<int, Spawner> spawnerTMs;
   public  Dictionary<int, BulletTM> bulletTMs;
    Dictionary<int, LevelTM> levelTMs;
    public TempelateContext() {
        towerTMs = new Dictionary<int, TowerTM>();
        skillModelTMs = new Dictionary<int, SkillModelTM>();
        // skillLevelTMs = new Dictionary<int, SkillLevelTM>();
        roleTMs = new Dictionary<int, RoleTM>();
        spawnerTMs = new Dictionary<int, Spawner>();
        bulletTMs = new Dictionary<int, BulletTM>();
        levelTMs = new Dictionary<int, LevelTM>();
    }
    public void Add_TowerTM(TowerTM tm) {
        towerTMs.Add(tm.typeID, tm);
    }
    public bool TryGet_TowerTM(int typeID, out TowerTM tm) {
        return towerTMs.TryGetValue(typeID, out tm);

    }
    public void Add_SkillModelTM(SkillModelTM tm) {
        skillModelTMs.Add(tm.typeID, tm);
    }
    public bool Get_SkillModelTM(int typeID, out SkillModelTM tm) {
        return skillModelTMs.TryGetValue(typeID, out tm);
    }
    // public void Add_SkillLevelTM(SkillLevelTM tm) {
    //     skillLevelTMs.Add(tm.id, tm);
    // }
    // public bool Get_SkillLevelTM(int id, out SkillLevelTM tm) {
    //     return skillLevelTMs.TryGetValue(id, out tm);
    // }
    public void Add_RoleTM(RoleTM tm) {
        roleTMs.Add(tm.typeID, tm);
    }
    public bool TryGet_RoleTM(int typeID, out RoleTM roletm) {
        return roleTMs.TryGetValue(typeID, out roletm);
    }
    // public void Add_SpawnerTM(SpawnerTM tm){
    //     spawnerTMs.Add(tm.typeID,tm);
    // }
    // public void 
    public void Add_BulletTM(BulletTM tm) {
        bulletTMs.Add(tm.typeID, tm);
    }
    public bool TryGet_BulTM(int typeID, out BulletTM tm) {
        return bulletTMs.TryGetValue(typeID, out tm);
    }
    public void Add_levelTM(LevelTM tm) {
        levelTMs.Add(tm.level, tm);
    }
    public bool TryGet_leveTM(int typeID, out LevelTM levelTM) {
        return levelTMs.TryGetValue(typeID, out levelTM);
    }
    // public void Add_levelMode(LevelMode levelMode){
    //     levelModes.Add(levelMode.id,levelMode);
    // }
    // public bool Tryget_levelMode(int )
}