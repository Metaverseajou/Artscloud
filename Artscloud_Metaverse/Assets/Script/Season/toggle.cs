using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class toggle : MonoBehaviour
{
    private GameObject Answer;
    void Start()
    {
        Answer = GameObject.Find("Answer");
    }
    public void spring1(bool isOn)
    {

        if (isOn)
        {
            Debug.Log("가장 많이 뽑힌 계절은 봄입니다.");
            Answer.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void spring2(bool isOn)
    {

        if (isOn)
        {
            Debug.Log("가장 많이 뽑힌 계절은 봄입니다.");
            Answer.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    public void summer1(bool isOn)
    {

        if (isOn)
        {
            Debug.Log("가장 많이 뽑힌 계절은 여름입니다.");
            Answer.transform.GetChild(2).gameObject.SetActive(true);
        }
    }

    public void summer2(bool isOn)
    {

        if (isOn)
        {
            Debug.Log("가장 많이 뽑힌 계절은 여름입니다.");
            Answer.transform.GetChild(3).gameObject.SetActive(true);
        }
    }

    public void Fall1(bool isOn)
    {

        if (isOn)
        {
            Debug.Log("가장 많이 뽑힌 계절은 가을입니다.");
            Answer.transform.GetChild(4).gameObject.SetActive(true);
        }
    }

    public void Fall2(bool isOn)
    {

        if (isOn)
        {
            Debug.Log("가장 많이 뽑힌 계절은 가을입니다.");
            Answer.transform.GetChild(5).gameObject.SetActive(true);
        }
    }

    public void Winter1(bool isOn)
    {

        if (isOn)
        {
            Debug.Log("가장 많이 뽑힌 계절은 겨울입니다.");
            Answer.transform.GetChild(6).gameObject.SetActive(true);
        }
    }

    public void Winter2(bool isOn)
    {

        if (isOn)
        {
            Debug.Log("가장 많이 뽑힌 계절은 겨울입니다.");
            Answer.transform.GetChild(7).gameObject.SetActive(true);
        }
    }
}
