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

    public void buttonMethode2()
    {
        Debug.Log("Done!");
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();

        a.d = false;
    }

    public void colorRed()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = Color.red;
    }

    public void colorGray()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = Color.gray;
    }

    public void colorGreen()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = Color.green;
    }
    public void colorYellow()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = Color.yellow;
    }
    public void colorBlue()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = Color.blue;
    }
    public void colorMagenta()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = Color.magenta;
    }
    public void colorBlack()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = Color.black;
    }
    public void colorCyan()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = Color.cyan;
    }


    public void colorClear()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = new Color(1f, 1f, 1f, 0f);
    }

    public void colorWhite()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        a.defaultMaterial.color = Color.white;
    }



}
