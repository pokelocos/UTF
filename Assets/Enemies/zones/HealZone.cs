using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealZone : MonoBehaviour
{
    public AudioClip damegeClip;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        var damageble = other.GetComponent<IDamageble>();

        if(damageble != null)
        {
            damageble.Heal(1);
            audioSource.PlayOneShot(damegeClip);
        }
    }
}
