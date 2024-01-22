using System.Collections.Generic;
public class TempelateContext {
    Dictionary<int, TowerTM> towerTMs;
    Dictionary<int, SkillModelTM> skillModelTMs;
    Dictionary<int, SkillLevelTM> skillLevelTMs;
    public TempelateContext() {
        towerTMs = new Dictionary<int, TowerTM>();
        skillModelTMs = new Dictionary<int, SkillModelTM>();
        skillLevelTMs = new Dictionary<int, SkillLevelTM>();
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
}