using UnityEngine;
public class GameContext{
    // ===Context===
    public UIcontext uicon;
    public TempelateContext tempCon;
    public AssetsContext assets;
    // ===Service===
    public IDService iDService;
    // ===Repository===
    public TowerRepo towerRepo;
    public SiteRepo siteRepo;
    // ===Entity===
    public GameEntity gameEntity;
    public PlayerEntity playerEntity;
    // ===Cavans===
    public Canvas gameCanvas;
    public GameContext(){
        iDService=new IDService ();
        towerRepo =new TowerRepo ();
        gameEntity=new GameEntity ();
        playerEntity=new PlayerEntity ();
        siteRepo=new SiteRepo ();
    }
    public void Inject(TempelateContext tempCon,AssetsContext assets,UIcontext uicon,Canvas gameCanvas){
        this.tempCon=tempCon;
        this.assets=assets;
        this.uicon=uicon;
        this.gameCanvas=gameCanvas;
    }
}