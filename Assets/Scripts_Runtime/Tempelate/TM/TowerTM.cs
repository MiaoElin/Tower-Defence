using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "TowerTM_", menuName = "TM/TowerTM", order = 0)]
public class TowerTM : ScriptableObject {
    public int typeID;
    public string typeName;
    public int price;
    public Vector2 size;
    public Sprite sprite;
    public SpawnerTM[] spawnerTMs;
    public int[] allowBuildTowers;
}
