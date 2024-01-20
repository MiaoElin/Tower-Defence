using UnityEngine;
[CreateAssetMenu(fileName ="SkillLevelTM_",menuName ="TM/SkillLevelTM")]
public class SkillLevelTM:ScriptableObject{
    public int typeID;
    public int skillLevel;
    public Sprite sprite;
    public float cdMax;
    public float maintain;
    public float interval;

}