using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "LevelMode_L_Easy_", menuName = "TM/LevelMode")]
public class LevelMode : ScriptableObject {
    public int level;
    public Difficulty difficulty;
    public ChallengeMode challengeMode;
    public int playerHp;
    public Vector2[] monsterPos;
    public Vector2[] homeEntities;
    public Vector2[] sitesPos;//塔位点
    public Vector2[] path;
    public SpawnerTM[] spawnerTMs;

}