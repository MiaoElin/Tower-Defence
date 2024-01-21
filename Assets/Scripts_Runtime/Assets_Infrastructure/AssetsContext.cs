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
    public void Add_Entity(string str, GameObject tm) {
        entities.Add(str, tm);
    }
    public bool TryGet_Entity(string str, out GameObject tm) {
        return entities.TryGetValue(str, out tm);
    }
    public void Add_Panel(string str, GameObject tm) {
        panels.Add(str, tm);
    }
    public bool TryGet_Panel(string str, out GameObject tm) {
        return panels.TryGetValue(str, out tm);
    }
}