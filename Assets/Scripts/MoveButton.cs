using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveButton: MonoBehaviour
{
    [SerializeField]
    Image img;
    [SerializeField]
    Image faceimg;

    float f = 100.0f;
    float fmax = 126.0f;
    bool ff = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ff)
        {
            f -= f/4.0f;
        }
        else
        {
            f += (100.0f-f)/4.0f;
        }
        faceimg.color = new Color(1,1,1,f);
        img.rectTransform.sizeDelta = new Vector2(292,f*1.26f);
    }

    public void Down(bool flag)
    {
        ff = flag;
    }
}
