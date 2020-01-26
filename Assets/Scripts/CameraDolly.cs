using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDolly : MonoBehaviour
{
  // public variables
  public float cameraPitchSpeed = 20f;
  public float cameraYawSpeed = 20f;


  // private variables
  // transform belongs to all game objects 
  Transform pitchObj;
  Transform yawObj;


  // only relies on internal values
  private void Awake()
  {
    pitchObj = new GameObject("Dolly Pitch").transform;
    yawObj = new GameObject("Dolly Yaw").transform;

    // sets yawObj as parent so transform on yaw affects pitch
    pitchObj.SetParent(yawObj);
    pitchObj.localPosition = Vector3.zero;
    // sets transform of camera dolly as parent to yaw
    yawObj.SetParent(transform);
    yawObj.localPosition = Vector3.zero;
  }

  private void Update()
  {
    // for left and right mouse movement
    yawObj.Rotate(new Vector3(0, Input.GetAxisRaw("Mouse X"), 0));
    // for up and down mouse movement
    pitchObj.Rotate(new Vector3(-Input.GetAxisRaw("Mouse Y"), 0, 0));
  }

  // only used for external references 
  private void Start()
  {
    CameraFollow cf = Camera.main.GetComponent<CameraFollow>();

    if (cf == null) cf = Camera.main.gameObject.AddComponent<CameraFollow>();

    // generic function with nameFunction<search>() to do a thing
    // FindObjectOfType<Camera>().GetComponent<CameraFollow>();
    cf.followTarget = pitchObj;

  }
}
