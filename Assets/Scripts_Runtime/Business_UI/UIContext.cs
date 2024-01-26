using System;
using UnityEngine;
public class UIcontext {
    // ===Panel===
    public Panel_Login panel_Login;//不要new 在Login_Open 通过预制件生成，预制件在ASsetContext里
    public Panel_Setting panel_Setting;
    public Panel_Heart panel_Heart;
    public Panel_BuildTower panel_BuildTower;
    public TempelateContext tempCon;
    // ======
    public Canvas panelCanvas;
    public Canvas gameCanvas;
    public AssetsContext assetsContext;
    UIEventCenter uIEventCenter;
    public UIEventCenter UIEventCenter => uIEventCenter;

    // int a=1;
    // public int b()=>a;
    // public int b(){return a;}
    public UIcontext() {
        uIEventCenter = new UIEventCenter();
    }
    public void Inject(Canvas panelCanvas,Canvas gameCanvas, AssetsContext assetsContext,TempelateContext tempelateContext) {
        this.panelCanvas = panelCanvas;
        this.assetsContext = assetsContext;
        this.gameCanvas=gameCanvas;
        this.tempCon=tempelateContext;
        }
}