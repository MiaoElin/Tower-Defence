using UnityEngine;
public class MainContext {
    public AssetsContext assetsContext;
    public GameContext gameCon;
    public UIcontext uIcon;
    public TempelateContext tempCon;
    public MainContext() {
        uIcon = new UIcontext();
        gameCon = new GameContext();
        tempCon=new TempelateContext ();
    }
    public void Inject(Canvas canvas, AssetsContext assetsContext) {
        uIcon.Inject(canvas, assetsContext);
        this.assetsContext = assetsContext;
        gameCon.Inject(tempCon);
    }
}