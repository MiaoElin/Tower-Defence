using UnityEngine;
public class MainContext {
    public AssetsContext assetsCon;
    public GameContext gameCon;
    public UIcontext uIcon;
    public TempelateContext tempCon;
    public MainContext() {
        uIcon = new UIcontext();
        gameCon = new GameContext();
        tempCon=new TempelateContext ();
        assetsCon=new AssetsContext ();
    }
    public void Inject(Canvas canvas) {
        uIcon.Inject(canvas, assetsCon);
        gameCon.Inject(tempCon,assetsCon);
    }
}