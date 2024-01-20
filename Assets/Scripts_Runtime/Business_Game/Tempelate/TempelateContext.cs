using System.Collections.Generic;
public class TempelateContext {
    Dictionary<int, TowerTM> towerTMs;
    Dictionary<int, SkillModelTM> skillModelTMs;
    Dictionary<int, SkillLevelTM> skillLevelTMs;
    public TempelateContext() {
        towerTMs = new Dictionary<int, TowerTM>();
        skillModelTMs = new Dictionary<int, SkillModelTM>();
        skillLevelTMs=new Dictionary<int, SkillLevelTM> ();
    }
    public void Add_TowerTM(TowerTM tm) {
        towerTMs.Add(tm.typeID, tm);
    }
    public TowerTM Get_TowerTM(int typeID) {
        return towerTMs[typeID];
    }
}