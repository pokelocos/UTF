using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private Transform player;

    public Transform pivot;
    public GameObject baseCannon;
    public GameObject cannon;

    public float speed = 5f;

    private float cannoncurrent = 0;
    public float cannonMax = 3f;

    [Header("Prefs")]
    public GameObject bulletPref;

    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectByType<CharacterStatus>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        // rotacion en torno al eje z de la base del cannon para que mirae simpre al player
        Vector3 dir = player.position - baseCannon.transform.position;
        dir.y = 0;
        Quaternion rotation = Quaternion.LookRotation(dir);

        // rotacion en torno al eje X del cannon para que mire siempre al player
        Vector3 dir2 = player.position - cannon.transform.position;

        float arv = Mathf.Clamp(Mathf.Atan2(dir2.z, dir2.y) * Mathf.Rad2Deg, -45, 45);
        cannon.transform.eulerAngles = new Vector3(arv, cannon.transform.eulerAngles.y, cannon.transform.eulerAngles.z);

        // dispara cuando el current llega a maximo
        if (cannoncurrent >= cannonMax)
        {
            cannoncurrent = 0;
            Shoot();
        }
        else
        {
            cannoncurrent += Time.deltaTime;
        }

    }

    void Shoot()
    {
        // instanciar bala
        GameObject bullet = Instantiate(bulletPref, cannon.transform.position, cannon.transform.rotation);
        //bullet.GetComponent<Rigidbody>().AddForce(cannon.transform.forward * 1000);
    }
}
