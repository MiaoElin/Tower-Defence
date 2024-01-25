using System.Collections.Generic;
public class TowerRepo{
    Dictionary<int,TowerEntity>all;
    TowerEntity [] tempAarry;
    public TowerRepo(){
        all=new Dictionary<int, TowerEntity> ();
        tempAarry=new TowerEntity[100];
    }
    public void Add(TowerEntity tower){
        all.Add(tower.id,tower);
    }
    public void Remove(TowerEntity tower){
        all.Remove(tower.id);
    }
    
}