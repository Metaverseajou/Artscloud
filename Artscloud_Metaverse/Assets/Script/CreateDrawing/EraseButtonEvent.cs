using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseButtonEvent : MonoBehaviour
{
    public GameObject button;
    public Material defaultMaterial; //Material for Line Renderer


    public void erasing()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
