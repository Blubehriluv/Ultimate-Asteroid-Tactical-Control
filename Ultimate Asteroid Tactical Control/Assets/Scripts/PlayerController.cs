using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float reverseSpeed;
    public float turnSpeed;
    private Rigidbody2D rb;
    private Transform tf;
    private float angle = 0.0f;
    public float thrust = 0.5f;
    private int destroyTime = 0;

    // Use this for initialization
    void Start()
    {
        turnSpeed = VariableHolder.playerRotationSpeed;
        //Creating variables for the transform components
        speed = VariableHolder.playerSpeed;
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
        DeathCount.playerAlive = true;
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

        //W pushes forward
        if (Input.GetKey(KeyCode.W))
        {
            //Movement with Force
            //rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);

            //Movement without Force
            tf.position += (tf.TransformDirection(Vector3.up) * speed * Time.deltaTime);
        }

        //S pulls back
        if (Input.GetKey(KeyCode.S))
        {
            tf.position += (tf.TransformDirection(Vector3.down) * reverseSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.FindGameObjectWithTag("Enemy"))
        {
            Debug.Log("Enemy killed a player");
            DeathCount.KilledByCol += 1;
            VariableHolder.playerLives -= 1;
            DeathCount.playerAlive = false;
            Destroy(gameObject, destroyTime);
        }
        else
        {
            Debug.Log("Something hit me, probably a bullet");
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (GameObject.FindGameObjectWithTag("DeathBox"))
        {
            Debug.Log("Death box has killed the player");
            DeathCount.KilledByCol += 1;
            VariableHolder.playerLives -= 1;
        }
    }
}
