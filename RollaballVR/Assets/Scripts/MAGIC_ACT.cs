using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class MAGIC_ACT : MonoBehaviour
{
    public float count = 0.0f;
    public double XMagic;
    public double YMagic;
    public float XMagicF;
    public float YMagicF;
    System.Random RX = new System.Random();
    System.Random RY = new System.Random();

    // Update is called once per frame
    void Update()
    {
        
        count = count + 0.1f;
        if(count >= 100.0f)
        {
            XMagic = RX.NextDouble()*10;
            YMagic = RY.NextDouble()*10;
            XMagicF = Convert.ToSingle(XMagic);
            YMagicF = Convert.ToSingle(YMagic);
            transform.position = new Vector3(XMagicF, .75f, YMagicF);
            count = 0;
        }
    }
}
