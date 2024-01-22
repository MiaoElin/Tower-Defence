using UnityEngine;
public class GameContext{
    public TempelateContext tempCon;
    public AssetsContext assets;
    public IDService iDService;
    public TowerRepo towerRepo;
    public GameEntity gameEntity;
    public GameContext(){
        iDService=new IDService ();
        towerRepo =new TowerRepo ();
        gameEntity=new GameEntity ();
    }
    public void Inject(TempelateContext tempCon,AssetsContext assets){
        this.tempCon=tempCon;
        this.assets=assets;
    }
}