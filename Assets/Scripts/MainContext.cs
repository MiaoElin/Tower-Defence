using UnityEngine;
public class MainContext {
    public AssetsContext assetsContext;
    public GameContext gameCon;
    public UIcontext uIcon;
    public int a;
    public MainContext() {
        // uIcon = new UIcontext();
        gameCon = new GameContext();
    }
    public void Inject(Canvas canvas, AssetsContext assetsContext) {
        uIcon.Inject(canvas, assetsContext);
        this.assetsContext = assetsContext;
        System.Console.WriteLine(uIcon.panel_Login);
        Debug.Log(a);
    }
}