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
    public HomeRepo homeRepo;
    public BulletRepo bulletRepo;
    public LevelRepo levelRepo;
    // ===Entity===
    public GameEntity gameEntity;
    public PlayerEntity playerEntity;
    public InputEntity input;
    // ===Cavans===
    public Canvas gameCanvas;
    public GameContext() {
        towerRepo = new TowerRepo();
        roleRepo = new RoleRepo();
        homeRepo = new HomeRepo();
        levelRepo = new LevelRepo();
        bulletRepo = new BulletRepo();

        gameEntity = new GameEntity();
        playerEntity = new PlayerEntity();
        iDService = new IDService();


    }
    public void Inject(InputEntity input, TempelateContext tempCon, AssetsContext assets, UIcontext uicon, Canvas gameCanvas) {
        this.input = input;
        this.tempCon = tempCon;
        this.assets = assets;
        this.uicon = uicon;
        this.gameCanvas = gameCanvas;
    }
    public LevelEntity TryGetLevel() {
        levelRepo.TryGet(gameEntity.levelID,out LevelEntity level);
        return level;
    }
}