using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeImage : MonoBehaviour
{
    // private Image rend;
    public Sprite sp1,sp2;
    public GameObject img;

    void Start()
    {
        img.GetComponent<Image>().sprite = sp1;
    }

     void Update()
    {

    //    if(Input.GetMouseButtonDown(0)){
    //        if(img.GetComponent<Image>().sprite == sp1)
    //             img.GetComponent<Image>().sprite = sp2;
    //         else if(img.GetComponent<Image>().sprite == sp2)
    //             img.GetComponent<Image>().sprite = sp1;
    //    }
    }

    public void imageChange()
    {
        // this.gameObject.GetComponent<SpriteRenderer>().sprite = newi;
            if(img.GetComponent<Image>().sprite == sp1)
                img.GetComponent<Image>().sprite = sp2;
            else if(img.GetComponent<Image>().sprite == sp2)
                img.GetComponent<Image>().sprite = sp1;    }

}
