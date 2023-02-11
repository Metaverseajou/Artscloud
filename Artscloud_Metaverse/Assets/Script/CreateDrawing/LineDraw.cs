using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDraw : MonoBehaviour
{
    public Camera cam;  //Gets Main Camera
    public Material defaultMaterial; //Material for Line Renderer
    public bool c = true;
    public bool d = true;

    int count = 0;
    int childNum = 0;
    public float w = 0.01f;

    private LineRenderer curLine;  //Line which draws now
    private int positionCount = 2;  //Initial start and end position
    private Vector3 PrevPos = Vector3.zero; // 0,0,0 position variable

    void Start()
    {
        defaultMaterial.color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        DrawMouse();
        count++;
    }

    void DrawMouse()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.3f));

        if (Input.GetMouseButtonDown(0))
        {
            createLine(mousePos);
        }
        else if (Input.GetMouseButton(0))
        {
            connectLine(mousePos);
        }
    }
    void createLine(Vector3 mousePos)
    {
        positionCount = 2;
        GameObject line = new GameObject("Line");
        LineRenderer lineRend = line.AddComponent<LineRenderer>();

        line.transform.parent = cam.transform;
        line.transform.position = mousePos;
        lineRend.startWidth = w;
        lineRend.endWidth = w;
        lineRend.numCornerVertices = 5;
        lineRend.numCapVertices = 5;
  
        lineRend.material = defaultMaterial;
 
       // lineRend.cam.transform.GetChild(count) = defaultMaterial;
       // lineRend.material = defaultMaterial;
        lineRend.SetPosition(0, mousePos);
        lineRend.SetPosition(1, mousePos);

        if (c == false)
        {
            w += 0.001f;
            w += 0.001f;

            c = true;
        }

        if (d == false)
        {
            w -= 0.001f;
            w -= 0.001f;

            if (w < 0.002)
            {
                w = 0.002f;
            }

            d = true;
        }



        curLine = lineRend;
    }

    void connectLine(Vector3 mousePos)
    {
        if (PrevPos != null && Mathf.Abs(Vector3.Distance(PrevPos, mousePos)) >= 0.001f)
        {
            PrevPos = mousePos;
            positionCount++;
            curLine.positionCount = positionCount;
            curLine.SetPosition(positionCount - 1, mousePos);
        }

    }
}
