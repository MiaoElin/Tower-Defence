using System.Collections.Generic;
using System;
public class SpawnerComponent {
    List<Spawner> all;
    public SpawnerComponent() {
        all = new List<Spawner>();
    }
    public void Add(Spawner spawner) {
        all.Add(spawner);
    }
    public void Remove(Spawner spawner) {
        all.Remove(spawner);
    }
    public Spawner TryGetCurrent() {
        return all[0];
    }
    public void Replace(int OldtypeID, Spawner newSpawner) {
        int index = all.FindIndex(spawner => spawner.typeID == OldtypeID);
        all[index] = newSpawner;
    }
    public void Foreach(Action<Spawner> action) {
        all.ForEach(action);
    }
}