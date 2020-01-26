using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToHeal : MonoBehaviour
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

    if (Input.GetButtonDown("Fire2") && activeCharacter != null)
    {
      activeCharacter.HealOverTime(50f, 2f);
    }
  }
}
