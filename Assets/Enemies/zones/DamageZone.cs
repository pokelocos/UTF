using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public AudioClip damegeClip;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        var damageble = other.GetComponent<IDamageble>();

        if(damageble != null)
        {
            damageble.AddDamage(1);
            audioSource.PlayOneShot(damegeClip);
        }
    }
}