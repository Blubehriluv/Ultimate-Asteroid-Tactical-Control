using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloaterController : MonoBehaviour
{
    public float turnSpeed;
    public float speed;
    private Transform tf;
    public Transform targetPosition;
    private bool alive;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        Vector3 vectorToTarget = targetPosition.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - 90;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, Time.deltaTime * turnSpeed);
        Invoke("Move", 2.0f);
    }

    void Move()
    {
        turnSpeed = 0;
        tf.position += (tf.TransformDirection(Vector3.up) * speed * Time.deltaTime);
    }
}
