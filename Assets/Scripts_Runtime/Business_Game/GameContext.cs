using UnityEngine;
public class GameContext {
    // ===Context===
    public UIcontext uicon;
    public TempelateContext tempCon;
    public AssetsContext assets;
    // ===Service===
    public IDService iDService;
    // ===Repository===
    public TowerRepo towerRepo;
    public RoleRepo roleRepo;
    // ===Entity===
    public GameEntity gameEntity;
    public PlayerEntity playerEntity;
    public InputEntity input;
    // ===Cavans===
    public Canvas gameCanvas;
    public GameContext() {
        iDService = new IDService();
        towerRepo = new TowerRepo();
        roleRepo = new RoleRepo();
        gameEntity = new GameEntity();
        playerEntity = new PlayerEntity();

    }
    public void Inject(InputEntity input, TempelateContext tempCon, AssetsContext assets, UIcontext uicon, Canvas gameCanvas) {
        this.input = input;
        this.tempCon = tempCon;
        this.assets = assets;
        this.uicon = uicon;
        this.gameCanvas = gameCanvas;
    }
}