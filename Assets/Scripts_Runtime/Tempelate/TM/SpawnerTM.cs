using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "SpawnerTM_", menuName = "TM/SpawnerTM")]
public class SpawnerTM : ScriptableObject {
    public int typeID;
    public string typeName;
    public Ally ally;
    public int roleTypeID;
    public Vector2[] rolePath;
    public int roleCount;
    public bool isSpawn;
    public float cd;
    public float cdMax;
    public float maintain;
    public float maintainTimer;
    public float interval;
    public float timer;
    public Vector2 SpawerPos;
}