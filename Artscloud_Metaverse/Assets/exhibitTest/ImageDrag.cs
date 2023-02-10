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
        //changeImg = Assets.exhibitTest.Load<Sprite>("Assets/exhibitTest/동숲_쪽");
    }

    private void Update()
    {
        if (isOnImage) //이미지 위에 마우스가 있을 떄
        {
            this.gameObject.GetComponent<Outline>().effectColor = Color.red; //테두리 빨간색

            if (Input.GetKeyDown(KeyCode.K)) //k키 누를 떄 이미지 추가
            {
                GameObject imgObj = Instantiate(this.gameObject, parent);
                //imgObj.transform.position = Input.mousePosition;
            }
        }
        else this.gameObject.GetComponent<Outline>().effectColor = new Vector4(0, 0, 0, 0); //이미지 위에 마우스 없을 때 테투리 색 없음
    }



    public void OnPointerEnter(PointerEventData eventData) //마우스 커서가 이미지에 들어갈 때
    {
        isOnImage = true;
    }

    public void OnPointerExit(PointerEventData eventData) //마우스 커서가 이미지에서 나올 떄
    {
        isOnImage = false;
    }



    public void OnPointerClick(PointerEventData eventData) //이미지를 클릭했을 때
    {
        if (Input.GetMouseButtonUp(1)) //오른쪽 마우스
        {
            if(parent.childCount > 1) //이미지가 1개만 남아있을 떄는 삭제되지 않도록
            {
                Destroy(this.gameObject); //이미지 삭제
            }
        }
        else if (Input.GetMouseButtonUp(0)) //왼쪽 마우스
        {
            if ((Time.time - clickTime) < 0.3f) //더블클릭 감지
            {
                this.gameObject.GetComponent<Image>().sprite = changeImg; //이미지 변경 코드
                clickTime = -1;
            }
            else clickTime = Time.time;
        }    
    }


    public void OnDrag(PointerEventData eventData) //마우스 드래그
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


