using UnityEngine;
public class MainContext {
    public AssetsContext assetsCon;
    public GameContext gameCon;
    public UIcontext uIcon;
    public TempelateRepo tempCon;
    public MainContext() {
        uIcon = new UIcontext();
        gameCon = new GameContext();
        tempCon=new TempelateRepo ();
        assetsCon=new AssetsContext ();
    }
    public void Inject(Canvas canvas) {
        uIcon.Inject(canvas, assetsCon);
        gameCon.Inject(tempCon,assetsCon);
    }
}