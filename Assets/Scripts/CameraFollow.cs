using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  public Transform followTarget;

  /// <summary>
  /// Awake is called when the script instance is being loaded.
  /// </summary>
  void Awake()
  {
    Cursor.lockState = CursorLockMode.Locked;
  }

  private void Update()
  {
    transform.position = followTarget.position;
    transform.rotation = followTarget.rotation;
  }

}
