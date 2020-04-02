using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargeterController : MonoBehaviour
{
    public float turnSpeed;
    public float speed;
    private Transform tf;
    public Transform targetPosition;
    private bool alive;
    private int destroyTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        speed = VariableHolder.targeterSpeed;
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.FindGameObjectWithTag("Projectile"))
        {
            Debug.Log("Big Death");
            DeathCount.KilledByBullet += 1;
            DeathCount.TotalKilledByPlayer += 1;
        }

        else if (GameObject.FindGameObjectWithTag("Enemy"))
        {
            Debug.Log("COLLISION");
            DeathCount.KilledByCol += 1;
        }

        else if (GameObject.FindGameObjectWithTag("Player"))
        {
            Debug.Log("We die together.");
            DeathCount.TotalKilledByPlayer += 1;
            DeathCount.KilledByCol += 1;
        }
        DeathCount.TotalKilled += 1;
        DeathCount.PlayingFieldCount -= 1;
        Destroy(gameObject, destroyTime);
    }
}
