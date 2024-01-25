using UnityEngine;
[CreateAssetMenu(fileName ="WaveTM_",menuName ="TM/WaveTM")]
public class WaveTM:ScriptableObject{
    public int typeID;
    public WaveSpawnTM[] waveSpawnTMs;
}