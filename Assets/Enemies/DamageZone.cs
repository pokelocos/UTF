using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var damageble = other.GetComponent<IDamageble>();

        if(damageble != null)
        {
            damageble.AddDamage(1);
        }
    }
}