using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterStatus : MonoBehaviour, IDamageble
{
    public int health = 5;
    public int maxHealth = 5;

    public int coins = 0;
    public int stars = 0;

    public Transform lastRespawnPoint;

    public void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
        Debug.Log("Coins: " + coins);
    }

    public void AddDamage(int damage)
    {
        health -= Mathf.Max(damage, 0);

        if (IsDead())
        {
            var newPos = new Vector3(
                lastRespawnPoint.position.x,
                lastRespawnPoint.position.y,
                lastRespawnPoint.position.z);
            this.transform.localPosition = newPos;

            health = maxHealth;
        }
    }

    public bool IsDead()
    {
        return health <= 0;
    }

    public void Heal(int heal)
    {
        health += Mathf.Max(heal, 0);

        health = Mathf.Min(health, maxHealth);
    }
}

public interface IDamageble
{
    public void AddDamage(int damage);

    public void Heal(int heal);

    public bool IsDead();

}
