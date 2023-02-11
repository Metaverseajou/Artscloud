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

    public GameObject canvasarea;
    public GameObject drawing;
    public GameObject cameraposition;

    //   Vector3 destination = new Vector3(-1.47f,-5.61f,-10.75f);

    void Start()
    {

        //     canvasarea.transform.position = drawing.transform.position;
        canvasarea.transform.position = new Vector3(0, 0, 0);
        
        defaultMaterial.color = Color.gray;

    }

    // Update is called once per frame
    void Update()
    {

       // Debug.Log(cameraposition.transform.position.z);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (5.68f <= cameraposition.transform.position.z || cameraposition.transform.position.z <= 5.9f)
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Draw") // Draw 오브젝트에 위치할때만 그리기
                    DrawMouse();
            }
        }

        for (int i = 0; i < canvasarea.transform.childCount; i++)
        {
            // canvasarea.transform.GetChild(i).localPosition = new Vector3(0, 0, 0);
            canvasarea.transform.GetChild(i).localPosition = canvasarea.transform.position;
        }
        count++;


    }

    void DrawMouse()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.5f));

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

        //  line.transform.parent = cam.transform;
        // make line in canvasarea ~
        line.transform.parent = canvasarea.transform;
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

        lineRend.useWorldSpace = false;

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

        //     canvasarea.transform.position = Vector3.MoveTowards(canvasarea.transform.position,destination,1);


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
