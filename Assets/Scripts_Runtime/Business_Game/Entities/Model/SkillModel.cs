using UnityEngine;
public class SkillModel {
    public int typeID;
    public int SkillLevel;
    public SkillType skillType;
    public SpriteRenderer sr;

    public float cd;
    public float cdMax;
    public float maintain;
    public float maintainTimer;
    public float interval;
    public float intervalTimer;
}