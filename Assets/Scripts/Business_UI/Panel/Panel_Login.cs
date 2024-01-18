using System;
using UnityEngine;
using UnityEngine.UI;
public class Panel_Login : MonoBehaviour
{
    public Button btn_Star;
    public Button btn_Exit;
    public Action OnClicStartkHandle;
    public void Ctor(){

        // btn_Star.onClick.AddListener(OnStarClick);
        // 匿名函数
        btn_Star.onClick.AddListener(()=>{
            OnClicStartkHandle.Invoke();
        });
    }
    public void Show(){
        gameObject.SetActive(true);
    }
    public void Close(){
        gameObject.SetActive(false);
    }
    
}