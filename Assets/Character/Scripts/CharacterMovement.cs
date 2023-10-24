using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Referencias")]
    public Animator animator;
    public CharacterController controller;
    
    [Header("Parametros")]
    [Range(0,100)] public float walkSpeed = 1.0f;
    public float rotationSpeed = 1.0f;
    public float jumpForce = 1.0f;
    public int maxJumps = 1;
    public LayerMask groundLayer;

    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var H_axis = Input.GetAxis("Horizontal");
        var V_axis = Input.GetAxis("Vertical");

        var axis = new Vector3(H_axis, 0, V_axis).normalized;
        if (axis.magnitude >= 0.1f) 
        {
            animator.SetBool("Running", true);
            animator.SetFloat("Speed", axis.magnitude);

            var speed = (V_axis > 0)? walkSpeed: walkSpeed * 0.5f;
            controller.Move(speed * Time.deltaTime * axis);

            animator.SetBool("Foward", V_axis > 0);
        }
        else
        {
            animator.SetBool("Running", false);
        }


        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Jump", true);
            controller.attachedRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
