using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    private GameObject Quest;
    private GameObject SoundManager;

    private AudioSource springsound;
    private AudioSource summersound;
    private AudioSource fallsound;
    private AudioSource wintersound;


    // Start is called before the first frame update
    void Start()
    {
      Quest =   GameObject.Find("Quest");
      SoundManager = GameObject.Find("SoundManager");
      
     springsound = SoundManager.transform.GetChild(0).GetComponent<AudioSource>();
     summersound = SoundManager.transform.GetChild(1).GetComponent<AudioSource>();
     fallsound = SoundManager.transform.GetChild(2).GetComponent<AudioSource>();
    wintersound = SoundManager.transform.GetChild(3).GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Spring1")){
            Debug.Log("봄 이미지 입장");
            Quest.transform.GetChild(0).gameObject.SetActive(true);

             springsound.Stop();
            summersound.Stop();
            fallsound.Stop();
            wintersound.Stop();

        }else if(other.gameObject.CompareTag("Spring2")){
            Debug.Log("봄 사운드 입장");
            Quest.transform.GetChild(1).gameObject.SetActive(true);
            springsound.Play();

            summersound.Stop();
            fallsound.Stop();
            wintersound.Stop();

        }else if(other.gameObject.CompareTag("Summer1")){
            Debug.Log("여름 이미지 입장");
            Quest.transform.GetChild(2).gameObject.SetActive(true);

            springsound.Stop();
            summersound.Stop();
            fallsound.Stop();
            wintersound.Stop();
        }else if(other.gameObject.CompareTag("Summer2")){
            Debug.Log("여름 사운드 입장");
            Quest.transform.GetChild(3).gameObject.SetActive(true);

            summersound.Play();

             springsound.Stop();
            fallsound.Stop();
            wintersound.Stop();
        }else if(other.gameObject.CompareTag("Fall1")){
            Debug.Log("가을 이미지 입장");
            Quest.transform.GetChild(4).gameObject.SetActive(true);

             springsound.Stop();
            summersound.Stop();
            fallsound.Stop();
            wintersound.Stop();

        }else if(other.gameObject.CompareTag("Fall2")){
            Debug.Log("가을 사운드 입장");
            Quest.transform.GetChild(5).gameObject.SetActive(true);

            fallsound.Play();

             springsound.Stop();
            summersound.Stop();
            wintersound.Stop();
        }else if(other.gameObject.CompareTag("Winter1")){
            Debug.Log("겨울 이미지 입장");
            Quest.transform.GetChild(6).gameObject.SetActive(true);

            springsound.Stop();
            summersound.Stop();
            fallsound.Stop();
            wintersound.Stop();

        }else if(other.gameObject.CompareTag("Winter2")){
            Debug.Log("겨울 사운드 입장");
            Quest.transform.GetChild(7).gameObject.SetActive(true);

            wintersound.Play();

             springsound.Stop();
            summersound.Stop();
            fallsound.Stop();
           


        }
    }
}
