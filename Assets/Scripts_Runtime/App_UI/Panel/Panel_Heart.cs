using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
public class Panel_Heart : MonoBehaviour {
    public Image imagePrefab;
    public Transform imageTransform;
    List<Image> images;
    public Panel_Heart() {
        images = new List<Image>();
    }
    public void Init(int hpNow) {
        int diff = hpNow - images.Count;
        // 一开始images.Count 为0,会画满血;如果diff=0，表示没有变化，不增加不减少
        if (diff > 0) {
            for (int i = 0; i < diff; i++) {
                Image im = GameObject.Instantiate(imagePrefab, imageTransform);
                images.Add(im);
            }
        }
        if (diff == 0) {
            // do nothing;
        }
        if (diff < 0) {
            // hpNow<image.Count 扣星  |diff|-1作为最大的值，
            for (int i = -diff - 1; i >= 0; i--) {

                // 找到最后一张图片
                Image lastOne = images[images.Count - 1];
                // 移除最后一张图片
                images.RemoveAt(images.Count - 1);
                // 销毁最后一张图片
                GameObject.Destroy(lastOne.gameObject);

            }
        }
    }
    public void Show() {
        gameObject.SetActive(true);
    }
    public void Close(){
        gameObject.SetActive(false);
    }
}