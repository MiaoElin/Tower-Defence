using UnityEngine;
public class MainContext {
    public AssetsContext assetsCon;
    public GameContext gameCon;
    public UIcontext uIcon;
    public TempelateContext tempCon;
    public MainContext() {
        uIcon = new UIcontext();
        gameCon = new GameContext();
        tempCon = new TempelateContext();
        assetsCon = new AssetsContext();
    }
    public void Inject(Canvas panelCanvas, Canvas gameCanvas) {
        uIcon.Inject(panelCanvas, gameCanvas, assetsCon);
        gameCon.Inject(tempCon, assetsCon, uIcon, gameCanvas);
    }
}