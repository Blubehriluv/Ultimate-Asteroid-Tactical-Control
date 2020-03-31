using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCount : MonoBehaviour
{
    public static int TotalKilled;
    public static int TotalKilledByPlayer;
    public static int KilledByBox;
    public static int KilledByCol;
    public static int KilledByBullet;
    public static int PlayingFieldCount;
    public int TotalPlayerLives = 3;
    public static int PlayerLives;
    public GameObject player;
    public static bool playerAlive;
    // Start is called before the first frame update
    void Start()
    {
        PlayingFieldCount = 0;
        PlayerLives = TotalPlayerLives;
        playerAlive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerAlive == false)
        {
            if (PlayerLives != 0)
            {
                Instantiate(player);
                Debug.Log("Spawning the player.");
            }
            else
            {
                SceneManager.LoadScene("GameOver");

            }
        }
    }
}
