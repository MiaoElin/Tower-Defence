using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientMain : MonoBehaviour {
    // Start is called before the first frame update
    MainContext mainContext;
    public Canvas panelCanvas;
    public Canvas gameCanvas;
    // Canvas canvas; //在ClientMain下直接挂了Canvas就不用声明了
    // AssetsContext assetsContext;//不在ClientMain下挂的话，Getcomponent是拿不到东西的
    void Start() {
        Debug.Log("hello world");
        // 设置帧率
        Application.targetFrameRate = 120;
        // 初始化
        mainContext = new MainContext();
        // 注入 
        // gameObject.GetComponentInChildren<Canvas[]>();

        mainContext.Inject(panelCanvas, gameCanvas);
        // event
        BindEvent();
        // Init
        Init();
        // 开始
        LoginController.Enter(mainContext);
        // Panel_Login panel=GameObject.Instantiate(panel_Login,gameObject.GetComponentInChildren<Canvas>().transform);

    }
    void Init() {
        TempelateInfra.LoadAll(mainContext.tempCon);
        AssetsInfra.LoadAll(mainContext.assetsCon);
    }
    void BindEvent() {
        UIEventCenter uIEventCenter = mainContext.uIcon.UIEventCenter;
        uIEventCenter.Login_OnClickStartHandle += () => {
            UIApp.P_Login_Close(mainContext.uIcon);
            Gamecontroller.EnterGame(mainContext.gameCon);
        };
        uIEventCenter.Login_OnClickSettingHandle += () => {
            UIApp.P_Setting_Open(mainContext.uIcon);
        };
        uIEventCenter.Setting_OnClickCloseHandle += () => {
            UIApp.P_Setting_Close(mainContext.uIcon);
        };
        uIEventCenter.Tower_OnClickHandle += (TowerEntity tower) => {
            UIApp.P_BuildTower_Open(mainContext.uIcon,tower);
        };
        uIEventCenter.Tower_UpskillHandle+=(int skillLevelTM_id)=>{
            UIApp.Panel_BuildTower_Close(mainContext.uIcon);
            
        };
    }
    // Update is called once per frame
    void Update() {
        Gamecontroller.Tick(mainContext.gameCon);
    }
}
