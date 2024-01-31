using System.Collections.Generic;
using UnityEngine;
public class AssetsContext {
    // public Panel_Login panel_Login;
    // public Panel_Setting panel_Setting;
    Dictionary<string, GameObject> panels;
    Dictionary<string, GameObject> entities;

    public AssetsContext() {
        panels = new Dictionary<string, GameObject>();
        entities = new Dictionary<string, GameObject>();
    }
    public void Add_Entity(string str, GameObject prefab) {
        entities.Add(str, prefab);
    }
    public bool TryGet_Entity(string str, out GameObject prefab) {
        return entities.TryGetValue(str, out prefab);
    }
    public void Add_Panel(string str, GameObject prefab) {
        panels.Add(str, prefab);
    }
    public bool TryGet_Panel(string str, out GameObject prefab) {
        return panels.TryGetValue(str, out prefab);
    }
}