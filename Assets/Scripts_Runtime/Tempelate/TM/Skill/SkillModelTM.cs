using UnityEngine;
[CreateAssetMenu(fileName = "SkillModelTM_S", menuName = "TM/SkillModelTM", order = 0)]
public class SkillModelTM : ScriptableObject {
    public int typeID;
    public int SkillLevel;
    public SkillType skillType;
    public int bulTypeID;
    public SkillLevelTM[] skillLevelTMs;

}
