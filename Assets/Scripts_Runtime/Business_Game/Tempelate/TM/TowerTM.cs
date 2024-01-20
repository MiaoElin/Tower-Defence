using UnityEngine;
[CreateAssetMenu(fileName = "TowerTM_", menuName = "TM/TowerTM", order = 0)]
public class TowerTM : ScriptableObject {
    public int typeID;
    public int SkillLevel;
    public SkillModelTM[] skillModelTMs;

}
