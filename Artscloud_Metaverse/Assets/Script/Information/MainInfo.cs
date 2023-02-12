using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainInfo : MonoBehaviour
{
    private GameObject Infocanvas;
    public float time = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Infocanvas = GameObject.Find("Intro");
        Invoke("Info1",time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Info1(){
        Infocanvas.transform.GetChild(0).gameObject.SetActive(true);
        Invoke("Info2",time);
    }

    void Info2(){
        Infocanvas.transform.GetChild(0).gameObject.SetActive(false);
        Infocanvas.transform.GetChild(1).gameObject.SetActive(true);
        Invoke("Info3",time);
    }

    void Info3(){
        Infocanvas.transform.GetChild(1).gameObject.SetActive(false);
        Infocanvas.transform.GetChild(2).gameObject.SetActive(true);
        Invoke("Info4",time);
    }

    void Info4(){
        Infocanvas.transform.GetChild(2).gameObject.SetActive(false);
        Infocanvas.transform.GetChild(3).gameObject.SetActive(true);
        Invoke("Info5",time);
    }

    void Info5(){
        Infocanvas.transform.GetChild(3).gameObject.SetActive(false);
        Infocanvas.transform.GetChild(4).gameObject.SetActive(true);
        Invoke("Info6",time);
    }

    void Info6(){
        Infocanvas.transform.GetChild(4).gameObject.SetActive(false);
        Infocanvas.transform.GetChild(5).gameObject.SetActive(true);
        Invoke("Info7",time);
    }

    void Info7(){
        Infocanvas.transform.GetChild(5).gameObject.SetActive(false);
    }
}
