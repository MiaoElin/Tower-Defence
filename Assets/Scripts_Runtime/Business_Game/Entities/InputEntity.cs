using UnityEngine;
public class InputEntity {
    public Vector2 screenMousePos;
    public Vector2 worldMousePos;
    public bool isLeftMouseDown;

    public void Process(Camera camera) {
        screenMousePos = Input.mousePosition;
        worldMousePos =camera.ScreenToWorldPoint(screenMousePos);
        isLeftMouseDown=Input.GetMouseButtonDown(0);
    }
}