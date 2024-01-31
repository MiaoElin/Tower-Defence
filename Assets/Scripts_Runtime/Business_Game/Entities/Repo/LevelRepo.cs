using System.Collections.Generic;
public class LevelRepo {
    Dictionary<int, LevelEntity> all;
    LevelEntity[] tempArray;
    public LevelRepo() {
        all = new Dictionary<int, LevelEntity>();
        tempArray = new LevelEntity[1000];
    }
    public void Add(LevelEntity level) {
        all.Add(level.id, level);
    }
    public void Remove(LevelEntity level) {
        all.Remove(level.id);
    }
    public bool TryGet(int levelid,out LevelEntity level){
       return  all.TryGetValue(levelid,out level);
    }
    public int TakeAll(out LevelEntity[] all_levels) {
        if (all.Count > tempArray.Length) {
            tempArray = new LevelEntity[all.Count * 2];
        }
        all.Values.CopyTo(tempArray, 0);
        all_levels = tempArray;
        return all.Count;
    }
}
