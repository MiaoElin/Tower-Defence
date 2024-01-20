using UnityEngine;
[CreateAssetMenu(fileName = "SkillModelTM_", menuName = "TM/SkillModelTM", order = 0)]
public class SkillModelTM : ScriptableObject {
    public int typeID;
    public int SkillLevel;
    public SkillType skillType;
    public SkillLevelTM[] skillLevelTMs;

}
