using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBehaviourScript : MonoBehaviour
{
    RaycastHit hitLayerMask;

    private void OnMouseDrag()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 1000, Color.green);

        int layerMask = 1 << LayerMask.NameToLayer("Space");
        if (Physics.Raycast(ray, out hitLayerMask, Mathf.Infinity, layerMask))
        {
            float z = this.transform.position.z; //높이 저장 
            this.transform.position = new Vector3(hitLayerMask.point.x, hitLayerMask.point.y, z);
        }
    }


}
