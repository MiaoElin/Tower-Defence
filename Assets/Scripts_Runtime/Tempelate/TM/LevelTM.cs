using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "LevelTM_L_Easy_", menuName = "TM/LevelTM")]
public class LevelTM : ScriptableObject {
    public int level;
    public int typeID;
    public Difficulty difficulty;
    public ChallengeMode challengeMode;
    public int playerHp;
    public Sprite sprite;
    public List<HomeEntityTM> homeEntities;
    public List<Vector2> sitePos;
    public List<Vector2[]> paths;
    public List<SpawnerTM> spawnerTMs;

}