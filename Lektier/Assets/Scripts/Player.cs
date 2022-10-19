using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform groundCheckTransform;
    public LayerMask playerMask;
    private bool JumpKeyWasPressed;
    private float HorizontalInput;
    private Rigidbody rigidbodyComponent;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpKeyWasPressed = true;
        }

        HorizontalInput = Input.GetAxis("Horizontal");
    }

    // FixedUpdate is called once every physics update
    private void FixedUpdate()
    {
        rigidbodyComponent.velocity = new Vector3(HorizontalInput, rigidbodyComponent.velocity.y, 0);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }

        if (JumpKeyWasPressed)
        {
            rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            JumpKeyWasPressed = false;
        }


    }

}