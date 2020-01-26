using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
  float health;
  [SerializeField]
  float armor;
  float shield;
  [SerializeField]
  float maxHealth;

  /// <summary>
  /// Awake is called when the script instance is being loaded.
  /// </summary>
  void Awake()
  {
    health = maxHealth;
  }

  public void TakeDamage(float amount)
  {
    if (armor > 0f)
    {
      ChangeArmor(-amount);
    }
    ChangeHealth(-amount);
  }

  public void Heal(float amount)
  {
    ChangeHealth(amount);
  }

  public void HealOverTime(float amount, float seconds)
  {
    // start Coroutine in unity
    // auto applies to game object
    StartCoroutine(HoTRoutine(amount / seconds, seconds));
  }

  //coRoutine will run every frame in parallel
  private IEnumerator HoTRoutine(float amount, float seconds)
  {
    while (seconds > 0)
    {
      seconds -= Time.deltaTime;
      Heal(amount * Time.deltaTime);
      yield return null;
    }

  }

  public void ChangeHealth(float amount)
  {
    health = Mathf.Clamp(health + amount, 0, maxHealth);
  }
  public void ChangeArmor(float amount)
  {
    float remainder = 0f;
    armor = Mathf.Clamp(armor + amount, 0, 200f);

    if (-amount > armor)
    {
      remainder = amount + armor;
    }
    if (remainder < 0f)
    {
      ChangeHealth(remainder);
    }

  }
}
