using UnityEngine;
public class SkillModel {
    public int typeID;
    public int SkillLevel;
    public SkillType skillType;//区分是发射子弹，还是近战攻击；
    public int bulTypeID;
    // ===level===
    public Sprite sprite;
    public float cd;
    public float cdMax;
    public float maintain;
    public float maintainTimer;
    public float interval;
    public float intervalTimer;
    public SkillModel() {
    }
}