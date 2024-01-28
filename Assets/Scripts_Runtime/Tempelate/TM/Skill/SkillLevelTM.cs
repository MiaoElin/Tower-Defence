using UnityEngine;
[CreateAssetMenu(fileName = "SkillLevelTM_S_", menuName = "TM/SkillLevelTM")]
public class SkillLevelTM : ScriptableObject {
    public int skillTypeID;
    public int level;
    public int bulTypeID;
    public float cdMax;
    public float maintain;
    public float interval;

}