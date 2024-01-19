using System;
using UnityEngine;
public class UIEventCenter {
    public event Action Login_OnClickStartHandle;
    public event Action Login_OnClickExitHandle;
    public UIEventCenter(){

    }
    public void TearDown() {
        
    }
    public void Login_Start()=>Login_OnClickStartHandle.Invoke();
    public void Login_Exit()=>Login_OnClickExitHandle();
}