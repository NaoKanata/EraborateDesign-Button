using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEffect : MonoBehaviour
{
    Vector2 oPos;
    RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
        //RectTransformを取得
        rt = GetComponent<RectTransform>();
        //初期位置を取得
        oPos = rt.anchoredPosition;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    //y座標を移動させる関数
    public void MovePos(int y)
    {
        rt.anchoredPosition = new Vector2(rt.anchoredPosition.x,oPos.y+y);
    }
}
