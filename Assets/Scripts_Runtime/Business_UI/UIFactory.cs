using UnityEngine;
public static class UIFactory {
    public static T PCreate<T>(UIcontext con)where T:MonoBehaviour {
        string str = typeof(T).Name;
        bool has = con.assetsContext.TryGet_Panel(str, out GameObject tm);
        if (!has) {
            Debug.LogError($"UIFactory.CreatePanel:{str}not found");
            return default;
        }
        return GameObject.Instantiate(tm,con.canvas.transform).GetComponent<T>();
        
    }
    public static Panel_Login P_Login_Create(UIcontext con){
        return PCreate<Panel_Login>(con);
    }
    public static Panel_Setting P_Setting_Create(UIcontext con){
        return PCreate<Panel_Setting>(con);
    }
}