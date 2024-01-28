using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "LevelTM_L", menuName = "TM/LevelTM")]
public class LevelTM : ScriptableObject {
    public int level;
    public Sprite map;
    public LevelMode[]levelModes;
}