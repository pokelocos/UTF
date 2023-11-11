using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject pivot;

    private void OnTriggerEnter(Collider other)
    {
        var characterStatus = other.GetComponent<CharacterStatus>();

        if (characterStatus != null)
        {
            characterStatus.stars++;
            Destroy(pivot);
        }

    }
}
