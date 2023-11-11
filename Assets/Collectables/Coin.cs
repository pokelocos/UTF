using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject pivot;

    private void OnTriggerEnter(Collider other)
    {
        var characterStatus = other.GetComponent<CharacterStatus>();

        if (characterStatus != null)
        {
            characterStatus.coins++;
            Destroy(pivot);
        }
    }
}
