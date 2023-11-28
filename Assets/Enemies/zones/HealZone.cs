using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var damageble = other.GetComponent<IDamageble>();

        if(damageble != null)
        {
            damageble.Heal(1);
        }
    }
}
