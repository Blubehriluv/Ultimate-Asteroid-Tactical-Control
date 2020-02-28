using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float reverseSpeed;
    public float turnSpeed = 150;
    private Rigidbody2D rb;
    private Transform tf;
    private float angle = 0.0f;
    public float thrust = 0.5f;

    // Use this for initialization
    void Start()
    {
        //Creating variables for the transform components
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //D turns the player right
        if (Input.GetKey(KeyCode.D))
        {
            angle -= turnSpeed * Time.deltaTime;
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }

        //A turns the player left
        if (Input.GetKey(KeyCode.A))
        {
            angle += turnSpeed * Time.deltaTime;
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }

        //Spacebar pushes forward
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
            //tf.position += (tf.TransformDirection(Vector3.up) * speed * Time.deltaTime);
        }

        //S pulls back
        if (Input.GetKey(KeyCode.S))
        {
            tf.position += (tf.TransformDirection(Vector3.down) * reverseSpeed * Time.deltaTime);
        }
    }
}
