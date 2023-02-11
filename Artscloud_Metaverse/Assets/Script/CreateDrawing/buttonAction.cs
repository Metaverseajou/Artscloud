using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAction : MonoBehaviour
{

    public Material redMat;

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

        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = Color.red;
        a.defaultMaterial = redMat;
}

    public void colorGray()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();

        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = Color.gray;
        a.defaultMaterial = redMat;
    }

    public void colorGreen()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();

        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = Color.green;
        a.defaultMaterial = redMat;
    }
    public void colorYellow()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();
        Debug.Log("노란색 눌렀당");
        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = Color.yellow;
        a.defaultMaterial = redMat;
    }

    public void colorBlue()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();

        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = Color.blue;
        a.defaultMaterial = redMat;
    }

    public void colorMagenta()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();

        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = Color.magenta;
        a.defaultMaterial = redMat;
    }

    public void colorBlack()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();

        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = Color.black;
        a.defaultMaterial = redMat;
    }

    public void colorCyan()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();

        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = Color.cyan;
        a.defaultMaterial = redMat;
    }


    void colorClear()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();

        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = new Color(0, 0, 0, 0);
        a.defaultMaterial = redMat;
    }

    public void colorWhite()
    {
        LineDraw a = GameObject.Find("drawing").GetComponent<LineDraw>();

        redMat = new Material(Shader.Find("Unlit/Color"));
        redMat.color = Color.white;
        a.defaultMaterial = redMat;
    }



}
