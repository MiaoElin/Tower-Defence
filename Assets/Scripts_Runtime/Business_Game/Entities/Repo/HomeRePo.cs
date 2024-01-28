using System.Collections.Generic;
using UnityEngine;
public class HomeRepo {
    Dictionary<int, HomeEntity> all;
    HomeEntity[] tempArray;
    public HomeRepo() {
        all = new Dictionary<int, HomeEntity>();
        tempArray = new HomeEntity[10];
    }
    public void Add(HomeEntity home) {
        all.Add(home.entityID, home);
    }
    public void Destroy(HomeEntity home) {
        all.Remove(home.entityID);
    }
    public int TakeAll(out HomeEntity[] all_home) {
        all.Values.CopyTo(tempArray, 0);
        all_home = tempArray;
        return all.Count;
    }
}