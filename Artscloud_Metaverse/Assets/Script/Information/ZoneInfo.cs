using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneInfo : MonoBehaviour
{
    private GameObject Infocanvas;
    // Start is called before the first frame update
     void Start()
    {
        Infocanvas = GameObject.Find("Intro");
       
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SeasonArea"))
        {
             Infocanvas.transform.GetChild(7).gameObject.SetActive(true);
             Debug.Log("SesaonArea 입장");
        }else if (other.gameObject.CompareTag("DrawArea"))
        {
             Infocanvas.transform.GetChild(8).gameObject.SetActive(true);
             Debug.Log("DrawArea 입장");
        }else if (other.gameObject.CompareTag("ExhibitArea"))
        {
             Infocanvas.transform.GetChild(9).gameObject.SetActive(true);
             Debug.Log("ExhibitArea 입장");
        }

    }

     private void OnTriggerExit(Collider other)
    {
         if (other.gameObject.CompareTag("SeasonArea"))
        {
             Infocanvas.transform.GetChild(7).gameObject.SetActive(false);
              Debug.Log("SeasonArea 퇴장");
        }else if (other.gameObject.CompareTag("DrawArea"))
        {
             Infocanvas.transform.GetChild(8).gameObject.SetActive(false);
             Debug.Log("DrawArea 퇴장");
        }else if (other.gameObject.CompareTag("ExhibitArea"))
        {
             Infocanvas.transform.GetChild(9).gameObject.SetActive(false);
             Debug.Log("ExhibitArea 퇴장");
        }

    }
}
