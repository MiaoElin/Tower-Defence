using System;
using UnityEngine;
using UnityEngine.UI;
public class Panel_Setting : MonoBehaviour
{
    public Button btn_Music;
    public Button btn_KeySet;
    public Button btn_Language;
    public Button btn_Close;
    public Action OnMusicClickHandle;
    public Action OnKeySetClickHandle;
    public Action OnCloseClickHandle;
    public Action OnLangueClickHandle;
    public void Ctor()
    {
        btn_Music.onClick.AddListener(() =>
        {
            OnMusicClickHandle.Invoke();
        });
        btn_KeySet.onClick.AddListener(() =>
        {
            OnKeySetClickHandle.Invoke();
        });
        btn_Close.onClick.AddListener(()=>{
            OnCloseClickHandle.Invoke();
        });
        btn_Language.onClick.AddListener(()=>{
            OnLangueClickHandle.Invoke();
        });
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
}