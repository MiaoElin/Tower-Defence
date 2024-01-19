using System;
using UnityEngine;
using UnityEngine.UI;
public class Panel_Login : MonoBehaviour
{
    public Button btn_Star;
    public Button btn_Exit;
    public Button btn_Setting;
    public Action OnClickStartkHandle;
    public Action OnClickExitHandle;
    public void Ctor(){

        // btn_Star.onClick.AddListener(OnClickExitHandle);
        // 匿名函数
        btn_Star.onClick.AddListener(()=>{
            OnClickStartkHandle.Invoke();
        });
        btn_Exit.onClick.AddListener(()=>{
            OnClickExitHandle.Invoke();
        });


    }
    public void Show(){
        gameObject.SetActive(true);
    }
    public void Close(){
        gameObject.SetActive(false);
    }
    
}