using UnityEngine;
public class GameContext{
    public TempelateRepo tempCon;
    public AssetsContext assets;
    public GameContext(){
    }
    public void Inject(TempelateRepo tempCon,AssetsContext assets){
        this.tempCon=tempCon;
        this.assets=assets;
    }
}