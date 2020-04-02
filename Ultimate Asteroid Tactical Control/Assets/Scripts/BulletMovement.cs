using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private GameObject boolet;
    private Rigidbody2D rb;
    public int destroyTime = 0;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bulletSpeed = VariableHolder.bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.FindGameObjectWithTag("Enemy") == other)
        {
            Debug.Log("Enemy has been shot and killed");
            DeathCount.KilledByBullet += 1;
            DeathCount.PlayingFieldCount -= 1;
            DeathCount.TotalKilled += 1;
            DeathCount.TotalKilledByPlayer += 1;

            Destroy(other, destroyTime);
        }
    }
}
