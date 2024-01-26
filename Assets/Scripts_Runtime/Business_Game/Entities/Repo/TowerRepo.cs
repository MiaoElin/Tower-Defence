using System.Collections.Generic;
public class TowerRepo {
    Dictionary<int, TowerEntity> all;
    TowerEntity[] tempAarry;
    public TowerRepo() {
        all = new Dictionary<int, TowerEntity>();
        tempAarry = new TowerEntity[100];
    }
    public void Add(TowerEntity tower) {
        all.Add(tower.id, tower);
    }
    public void Remove(TowerEntity tower) {
        all.Remove(tower.id);
    }
    public void TryGet(int towerID,out TowerEntity tower){
        all.TryGetValue(towerID,out tower);
    }
    public int TakeAll(out TowerEntity[] all_tower) {
        if (all.Count > tempAarry.Length) {
            tempAarry = new TowerEntity[all.Count];
        }
        all.Values.CopyTo(tempAarry, 0);
        all_tower = tempAarry;
        return all.Count;
    }
}