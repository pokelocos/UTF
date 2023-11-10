using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVel;

    public float speed = 5f;
    public float jumpSpeed = 5f;

    private Vector3 jumpForce = Vector3.zero;
    public float gravity = 10f;

    public CharacterController characterController;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get axis horizontal vertical
        float H_axis = Input.GetAxis("Horizontal");
        float V_axis = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(H_axis, 0, V_axis).normalized;

        // preguntar si esta saltando
        bool jumpBtn = Input.GetButtonDown("Jump");
        if (jumpBtn)
        {
            // saltamos
            jumpForce.y = jumpSpeed * Time.deltaTime;
        }

        jumpForce.y -= gravity * Time.deltaTime;
        // aplicamos fuerza salto
        characterController.Move(jumpForce * Time.deltaTime);


        // pregutar si esta moviendo
        if (dir.magnitude >= 0.1f)
        {
            float angle = (Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg) + cam.transform.eulerAngles.y;
            float angle2 = Mathf.SmoothDampAngle(transform.eulerAngles.y,angle,ref turnSmoothVel, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f,angle2,0f);

            // movemos
            var dir2 = Quaternion.Euler(0f,angle,0f) * Vector3.forward;
            characterController.Move(dir2 * speed * Time.deltaTime);
        }


    }
}
