using UnityEngine;
using System.Collections.Generic;
public class Spawner {
    public int typeID;
    public string typeName;
    public Ally ally;
    public int roleTypeID;
    public List<Vector2> rolePath;
    public int roleCount;
    public bool isSpawn;///
    public float cd;
    public float cdMax;
    public float maintain;
    public float maintainTimer;
    public float interval;
    public float timer;

}