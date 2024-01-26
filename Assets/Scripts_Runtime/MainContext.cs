using UnityEngine;
public class MainContext {
    public AssetsContext assetsCon;
    public GameContext gameCon;
    public UIcontext uIcon;
    public TempelateContext tempCon;
    public InputEntity input;
    public MainContext() {
        uIcon = new UIcontext();
        gameCon = new GameContext();
        tempCon = new TempelateContext();
        assetsCon = new AssetsContext();
        input=new InputEntity ();
    }
    public void Inject(Canvas panelCanvas, Canvas gameCanvas) {
        uIcon.Inject(panelCanvas, gameCanvas, assetsCon,tempCon);
        gameCon.Inject(input,tempCon, assetsCon, uIcon, gameCanvas);
    }
}