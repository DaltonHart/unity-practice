using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDamage : MonoBehaviour
{
  public float checkDistance = 5f;

  Character activeCharacter;

  /// <summary>
  /// Update is called every frame, if the MonoBehaviour is enabled.
  /// </summary>
  void Update()
  {
    RaycastHit hitinfo;
    if (Physics.Raycast(transform.position, transform.forward, out hitinfo, checkDistance))
    {
      activeCharacter = hitinfo.collider.gameObject.GetComponent<Character>();
    }
    else
      activeCharacter = null;

    if (Input.GetButtonDown("Fire1") && activeCharacter != null)
    {
      activeCharacter.ChangeArmor(-23f);
    }
  }
}
