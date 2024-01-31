using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelEntity : MonoBehaviour {
    public int level;
    public int id;
    public Difficulty difficulty;
    public ChallengeMode challengeMode;
    public int playerHp;
    public SpriteRenderer map;
    public Vector2[] monsterPos;
    public Vector2[] homeEntities;
    public Vector2[] sitesPos;//塔位点
    public int sitePosCount;
    public Vector2[] path;
    public SpawnerComponent spawnerComponent;
    public List<int> allRoleID;
    public LevelEntity(){
       spawnerComponent=new SpawnerComponent ();
       sitePosCount=0;
    }
}