using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelEntity : MonoBehaviour {
    public int level;
    public int typeID;
    public Difficulty difficulty;
    public ChallengeMode challengeMode;
    public int playerHp;
    public Image map;
    public List<HomeEntity> homeEntities;
    public List<Vector2> sitesPos;//塔位点
    public List<Vector2[]> paths;
    public List<Spawner> spawners;


}