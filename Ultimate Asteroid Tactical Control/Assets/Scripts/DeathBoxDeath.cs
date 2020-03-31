using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBoxDeath : MonoBehaviour
{

    private int destroyTime = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.FindGameObjectWithTag("Projectile"))
        {
            Debug.Log("STOP SHOOTING AT MEEEE! DAAAAAMN! ASSHOOOOLE!");
        }

        else if (GameObject.FindGameObjectWithTag("Enemy"))
        {
            Debug.Log("Enemy has been killed");
            DeathCount.KilledByBox += 1;
            DeathCount.PlayingFieldCount -= 1;
            DeathCount.TotalKilled += 1;
        }

        else if (GameObject.FindGameObjectWithTag("Player"))
        {
            Debug.Log("dont fooken touch me m8");
            DeathCount.KilledByBox += 1;
            DeathCount.playerAlive = false;

        }
        Destroy(other.gameObject, destroyTime);
    }
}
