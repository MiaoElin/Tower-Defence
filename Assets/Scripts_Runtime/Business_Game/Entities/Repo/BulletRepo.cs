using System.Collections.Generic;
public class BulletRepo{
    Dictionary<int,BulletEntity>all;
    BulletEntity[]tempArray;
    public BulletRepo(){
        all=new Dictionary<int, BulletEntity> ();
        tempArray=new BulletEntity[1000];
    }
    public void Add(BulletEntity bullet){
        all.Add(bullet.id,bullet);
    }
    public void Remove(BulletEntity bullet){
        all.Remove(bullet.id);
    }
    public int TakeAll(out BulletEntity []all_bullets){
        if(all.Count>tempArray.Length){
            tempArray=new BulletEntity [all.Count*2];
        }
        all.Values.CopyTo(tempArray,0);
        all_bullets=tempArray;
        return all.Count;
    }
}