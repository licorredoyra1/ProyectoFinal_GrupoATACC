using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 10f;

    public float gravity = -12f;

    public float jumpHeight = 0.5f;

    public Transform groundCheck;

    public float gruoundDistance = 0.3f;

    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position,gruoundDistance,groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move* speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity* Time.deltaTime);
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", z);
    }
}
