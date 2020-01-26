using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OW
{
  public class Rhein : Player
  {

    // Start is called before the first frame update
    void Start()
    {
      maxHealth = 300f;
      health = maxHealth;
      recieveShield(50f);
      // GiveShieldToOtherPlayer(50f, this);
    }

    // Update is called once per frame
    void Update()
    {

    }
  }

}