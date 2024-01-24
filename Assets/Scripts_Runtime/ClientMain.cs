using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientMain : MonoBehaviour {
    // Start is called before the first frame update
    MainContext con;
    public Canvas panelCanvas;
    public Canvas gameCanvas;
    // Canvas canvas; //在ClientMain下直接挂了Canvas就不用声明了
    // AssetsContext assetsContext;//不在ClientMain下挂的话，Getcomponent是拿不到东西的
    void Start() {
        Debug.Log("hello world");
        // 设置帧率
        Application.targetFrameRate = 120;
        // 初始化
        con = new MainContext();
        // 注入 
        // gameObject.GetComponentInChildren<Canvas[]>();

        con.Inject(panelCanvas, gameCanvas);
        // event
        BindEvent();
        // Init
        Init();
        // 开始
        LoginController.Enter(con);
        // Panel_Login panel=GameObject.Instantiate(panel_Login,gameObject.GetComponentInChildren<Canvas>().transform);

    }
    void Init() {
        TempelateInfra.LoadAll(con.tempCon);
        AssetsInfra.LoadAll(con.assetsCon);
    }
    void BindEvent() {
        UIEventCenter uIEventCenter = con.uIcon.UIEventCenter;
        uIEventCenter.Login_OnClickStartHandle += () => {
            UIApp.P_Login_Close(con.uIcon);
            Gamecontroller.EnterGame(con.gameCon);
        };
        uIEventCenter.Login_OnClickSettingHandle += () => {
            UIApp.P_Setting_Open(con.uIcon);
        };
        uIEventCenter.Setting_OnClickCloseHandle += () => {
            UIApp.P_Setting_Close(con.uIcon);
        };
        // uIEventCenter.BuildTower1_OnClickHandle += (Vector2 sitePos, int siteEntityID) => {
        //     TowerEntity tower = TowerDomain.SpawnTower(con.gameCon, 1, sitePos);
        //     UIApp.Panel_BuildTower_Close(con.uIcon);
        //     con.gameCon.siteRepo.Remove(siteEntityID);
        // };
        // uIEventCenter.BuildTower2_OnClickHandle += (Vector2 sitePos, int siteEntityID) => {
        //     TowerEntity tower = TowerDomain.SpawnTower(con.gameCon, 2, sitePos);
        //     UIApp.Panel_BuildTower_Close(con.uIcon);
        //     con.gameCon.siteRepo.Remove(siteEntityID);
        // };
        // uIEventCenter.Tower_UpskillHandle += () => {
        //     // UIApp.Panel_BuildTower_Close(mainContext.uIcon);

        // };
        uIEventCenter.Site_OnClikHandle += (SiteEntity site) => {
            Debug.Log("bulid tower");
            UIApp.P_BuildTower_Open(con.uIcon, site);
        };
        uIEventCenter.BuildTower += () => {
            Debug.Log("2");
        };
    }
    // Update is called once per frame
    void Update() {
        Gamecontroller.Tick(con.gameCon);

        // Vector3 mousePos = Input.mousePosition;// 屏幕坐标;
        // // 屏幕坐标转换成世界坐标（点屏幕的时候，在对应的位置的世界坐标里建一座塔
        // Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
        // // 世界坐标转换成点坐标（将塔的位置转换成屏幕坐标，在屏幕生成对应panel）
        // Vector2 screenPos = Camera.main.WorldToScreenPoint(mouseWorldPos);
        // Debug.Log(mouseWorldPos);

    }
}
