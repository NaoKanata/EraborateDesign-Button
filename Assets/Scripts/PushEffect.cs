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
        rt = GetComponent<RectTransform>();
        oPos = rt.anchoredPosition;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovePos(int y)
    {
        rt.anchoredPosition = new Vector2(rt.anchoredPosition.x,oPos.y+y);
    }
}
