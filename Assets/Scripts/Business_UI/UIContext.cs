using System;
using UnityEngine;
public class UIcontext {
    public Panel_Login panel_Login;//不要new 在Login_Open 通过预制件生成，预制件在ASsetContext里
    public Panel_Setting panel_Setting;
    public Canvas canvas;
    public AssetsContext assetsContext;
    // public UIEventCenter UIEventCenter=>uIEventCenter;
    UIEventCenter uIEventCenter;
    public UIEventCenter UIEventCenter => uIEventCenter;

    // int a=1;
    // public int b()=>a;
    // public int b(){return a;}

    public UIcontext() {
        uIEventCenter = new UIEventCenter();
    }
    public void Inject(Canvas canvas, AssetsContext assetsContext) {
        this.canvas = canvas;
        this.assetsContext = assetsContext;
    }
}