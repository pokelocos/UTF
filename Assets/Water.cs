using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public float heigth = 1f;
    public float speed = 10.0f;

    private Vector3 startPos;
         

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = startPos + new Vector3(0, Mathf.Sin(Time.time * speed) * heigth, 0);
    }
}
