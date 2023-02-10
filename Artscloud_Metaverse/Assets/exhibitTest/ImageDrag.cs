using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageDrag : MonoBehaviour, IDragHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject prefab;
    public Transform parent;

    Boolean isOnImage = false;
    float clickTime = 0;

    public Sprite changeImg;

    RaycastHit hitLayerMask;

    private void start()
    {
        //changeImg = Assets.exhibitTest.Load<Sprite>("Assets/exhibitTest/����_��");
    }

    private void Update()
    {
        if (isOnImage) //�̹��� ���� ���콺�� ���� ��
        {
            this.gameObject.GetComponent<Outline>().effectColor = Color.red; //�׵θ� ������

            if (Input.GetKeyDown(KeyCode.K)) //kŰ ���� �� �̹��� �߰�
            {
                GameObject imgObj = Instantiate(this.gameObject, parent);
                //imgObj.transform.position = Input.mousePosition;
            }
        }
        else this.gameObject.GetComponent<Outline>().effectColor = new Vector4(0, 0, 0, 0); //�̹��� ���� ���콺 ���� �� ������ �� ����
    }



    public void OnPointerEnter(PointerEventData eventData) //���콺 Ŀ���� �̹����� �� ��
    {
        isOnImage = true;
    }

    public void OnPointerExit(PointerEventData eventData) //���콺 Ŀ���� �̹������� ���� ��
    {
        isOnImage = false;
    }



    public void OnPointerClick(PointerEventData eventData) //�̹����� Ŭ������ ��
    {
        if (Input.GetMouseButtonUp(1)) //������ ���콺
        {
            if(parent.childCount > 1) //�̹����� 1���� �������� ���� �������� �ʵ���
            {
                Destroy(this.gameObject); //�̹��� ����
            }
        }
        else if (Input.GetMouseButtonUp(0)) //���� ���콺
        {
            if ((Time.time - clickTime) < 0.3f) //����Ŭ�� ����
            {
                this.gameObject.GetComponent<Image>().sprite = changeImg; //�̹��� ���� �ڵ�
                clickTime = -1;
            }
            else clickTime = Time.time;
        }    
    }


    public void OnDrag(PointerEventData eventData) //���콺 �巡��
    {
        Ray ray = Camera.main.ScreenPointToRay(eventData.position);
        Debug.DrawLine(ray.origin, ray.direction * 1000, Color.red);

        int layerMask = 1 << LayerMask.NameToLayer("Space");
        if (Physics.Raycast(ray, out hitLayerMask, Mathf.Infinity, layerMask))
        {

            if (hitLayerMask.point.z > 13)
            {
                this.transform.localEulerAngles = new Vector3(0, 0, 0);
                float z = 13.34f;
                this.transform.position = new Vector3(hitLayerMask.point.x, hitLayerMask.point.y, z);
            }
            else if (hitLayerMask.point.z > 9.5)
            {
                this.transform.localEulerAngles = new Vector3(0, -90, 0);
                float x = this.transform.position.x;
                this.transform.position = new Vector3(x, hitLayerMask.point.y, hitLayerMask.point.z);
            }
            else
            {
                this.transform.localEulerAngles = new Vector3(0, -180, 0);
                float z = 9.45f;
                this.transform.position = new Vector3(hitLayerMask.point.x, hitLayerMask.point.y, z);
            }
        }
    }
}


