using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OW
{
  public class Player : MonoBehaviour
  {
    // [SerializeField]
    protected float health;
    // [SerializeField]
    protected float shield;
    // [SerializeField]
    protected float armor;
    // [SerializeField]
    protected float maxHealth;
    public float Health
    {
      get
      {
        return health;
      }
      set
      {
        if (value < 0)
          health = 0;
        else if (value > maxHealth)
          health = maxHealth;
        else
          health = value;
      }
    }

    public Player(float health = 0f, float shield = 0f, float armor = 0f)
    {
      this.health = health;
      this.shield = shield;
      this.armor = armor;
    }

    public void recieveShield(float amount)
    {
      this.shield += amount;
    }

    public void GiveShieldToOtherPlayer(float amnt, Player other)
    {
      other.recieveShield(amnt);
    }

    // Start is called before the first frame update
    void Start()
    {
      Player kenny = new Player(health: 100f);
      kenny.recieveShield(50f);
    }

    // Update is called once per frame
    void Update()
    {

    }
  }
}