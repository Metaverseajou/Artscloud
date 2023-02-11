using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mysound : MonoBehaviour
{

    private GameObject Sound;
    private GameObject SoundManager;

    private AudioSource MyPlaceSound;
    private AudioSource BGMsound;

    // Start is called before the first frame update
    void Start()
    {
        Sound = GameObject.Find("Sound");
        SoundManager = GameObject.Find("SoundManager");

        MyPlaceSound = Sound.transform.GetChild(0).GetComponent<AudioSource>();
        BGMsound = SoundManager.transform.GetChild(4).GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("MySoundArea")){
            Debug.Log("전시장 입장");

            MyPlaceSound.Play();
            BGMsound.Stop();
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("MySoundArea")){
            Debug.Log("전시장 퇴장");

            BGMsound.Play();
            MyPlaceSound.Stop();
        }
    }
}
