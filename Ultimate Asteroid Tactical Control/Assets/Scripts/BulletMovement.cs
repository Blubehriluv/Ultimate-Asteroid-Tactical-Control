using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private GameObject boolet;
    private Rigidbody2D rb;
    public float bulletSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
    }
}
