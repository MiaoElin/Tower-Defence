using System.Collections.Generic;
public class TempelateContext {
    Dictionary<int, TowerTM> towerTMs;
    Dictionary<int, SkillModelTM> skillModelTMs;
    Dictionary<int, SkillLevelTM> skillLevelTMs;
    Dictionary<int, RoleTM> roleTMs;
    Dictionary<int,SpawnerTM>spawnerTMs;
    public TempelateContext() {
        towerTMs = new Dictionary<int, TowerTM>();
        skillModelTMs = new Dictionary<int, SkillModelTM>();
        skillLevelTMs = new Dictionary<int, SkillLevelTM>();
        roleTMs=new Dictionary<int, RoleTM> ();
        spawnerTMs=new Dictionary<int, SpawnerTM> ();
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
    // public bool Get_SkillModelTM(int typeID, out SkillModelTM tm) {
    //     return skillModelTMs.TryGetValue(typeID, out tm);

    // }
    public void Add_SkillLevelTM(SkillLevelTM tm) {
        skillLevelTMs.Add(tm.id, tm);
    }
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
}