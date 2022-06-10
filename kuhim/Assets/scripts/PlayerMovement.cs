using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movement();
    }

    void movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        rb.velocity = new Vector3(horizontal, rb.velocity.y, vertical);
    }
}
