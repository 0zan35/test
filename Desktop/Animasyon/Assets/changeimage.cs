using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeimage : MonoBehaviour
{
    public Sprite newi;
    void Start()
    {
        
    }

    public void imageChange()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = newi;
        Debug.Log("test");
    }

}
