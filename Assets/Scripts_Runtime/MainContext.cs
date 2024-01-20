using UnityEngine;
public class MainContext {
    public AssetsContext assetsContext;
    public GameContext gameCon;
    public UIcontext uIcon;
    public MainContext() {
        uIcon = new UIcontext();
        gameCon = new GameContext();
    }
    public void Inject(Canvas canvas, AssetsContext assetsContext) {
        uIcon.Inject(canvas, assetsContext);
        this.assetsContext = assetsContext;
    }
}