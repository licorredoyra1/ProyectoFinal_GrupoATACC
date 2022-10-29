using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastJump : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public bool grounded;
    public LayerMask mask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGround();
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }
    }

    public void CheckGround()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, Vector3.down * 1.5f, Color.green);
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.5f, mask))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }
}
