using UnityEngine;
[CreateAssetMenu(fileName = "WaveSpawnTM_L1_", menuName = "TM/WaveSpawnTM")]
public class WaveSpawnTM : ScriptableObject {
    public EntityTyPe entityTyPe;
    public int entityTypeID;
    public int conut;
    public float startTime;
    public float endTime;
    public float interval;
    public float timer;

}