using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAction : MonoBehaviour
{

    public void buttonMethode()
    {
        Debug.Log("Done!");
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.c = false;
    }

   
}
