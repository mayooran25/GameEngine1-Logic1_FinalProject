using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    public GameObject character;

    void Update()
    {
 
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), this.transform.rotation.x/*Input.GetAxisRaw("Mouse Y")*/);
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
      //  smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

       // transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);

      //  mouseLook.y = Mathf.Clamp(mouseLook.y, -25, -25); //up and down
       //mouseLook.x = Mathf.Clamp(mouseLook.x, -360, 360); //left and right
       
    }

    private void OnEnable()
    {
        mouseLook = Vector3.zero;
    }
}
