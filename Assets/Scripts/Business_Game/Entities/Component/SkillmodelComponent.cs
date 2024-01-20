using System.Collections.Generic;
using System;
public class SkillModelComponent{
    List<SkillModel>all;
    public SkillModelComponent(){
        all=new List<SkillModel> ();
    }
    public void Add(SkillModel skill){
        all.Add(skill);
    }
    public void Remove(SkillModel skill){
        all.Remove(skill);
    }
    public SkillModel TryGetCurrent(){
        return all[0];
    }
    public void Replace(int OldtypeID,SkillModel newSkill){
        int index =all.FindIndex(skill=>skill.typeID==OldtypeID);
        all[index]=newSkill;
    }
    public void Foreach(Action<SkillModel>action){
        all.ForEach(action);
    }

}