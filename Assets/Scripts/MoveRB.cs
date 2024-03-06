using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float flyUp = 0.5f;
    [SerializeField] private float flyDown = 0.5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * flyUp, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(Vector3.down * flyDown, ForceMode.Impulse);
        }
            
    }
}
