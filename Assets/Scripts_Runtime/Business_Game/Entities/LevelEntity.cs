using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelEntity : MonoBehaviour {
    public int level;
    public Difficulty difficulty;
    public ChallengeMode challengeMode;
    public int playerHp;
    public Image map;
    public Vector2[] homeEntities;
    public Vector2[] sitesPos;//塔位点
    public Vector2[]path;
    public SpawnerComponent spawnerComponent;
}