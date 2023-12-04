using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour
{
    public bool randomStart = false;

    public float heigth = 1f;
    public float speed = 10.0f;

    private Vector3 startPos;
    private float offsetTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        if (randomStart)
        {
            offsetTime = Random.Range(0, 360f);
        }
    }

    private void FixedUpdate()
    {
        this.transform.position = startPos + new Vector3(0, Mathf.Sin((Time.time + offsetTime) * speed) * heigth, 0);


    }
}
