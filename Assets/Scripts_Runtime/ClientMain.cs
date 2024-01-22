using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientMain : MonoBehaviour {
    // Start is called before the first frame update
    MainContext mainContext;
    // Canvas canvas; //在ClientMain下直接挂了Canvas就不用声明了
    // AssetsContext assetsContext;//不在ClientMain下挂的话，Getcomponent是拿不到东西的
    void Start() {
        Debug.Log("hello world");
        // 设置帧率
        Application.targetFrameRate = 120;
        // 初始化
        mainContext = new MainContext();
        // 注入 
        mainContext.Inject(gameObject.GetComponentInChildren<Canvas>());
        // event
        BindEvent();
        // Init
        Init();
        // 开始
        LoginBusiness.Enter(mainContext);
        // Panel_Login panel=GameObject.Instantiate(panel_Login,gameObject.GetComponentInChildren<Canvas>().transform);

    }
    void Init() {
        TempelateInfra.LoadAll(mainContext.tempCon);
        AssetsInfra.LoadAll(mainContext.assetsCon);
    }
    void BindEvent() {
        UIEventCenter uIEventCenter = mainContext.uIcon.UIEventCenter;
        uIEventCenter.Login_OnClickStartHandle += () => {
            UIApp.Login_Close(mainContext.uIcon);
            GameBusiness.EnterGame(mainContext.gameCon);
        };
        uIEventCenter.Login_OnClickSettingHandle += () => {
            UIApp.Setting_Open(mainContext.uIcon);
        };
        uIEventCenter.Setting_OnClickCloseHandle += () => {
            UIApp.Setting_Close(mainContext.uIcon);
        };
    }
    // Update is called once per frame
    void Update() {
        GameBusiness.Tick(mainContext.gameCon);
    }
}
