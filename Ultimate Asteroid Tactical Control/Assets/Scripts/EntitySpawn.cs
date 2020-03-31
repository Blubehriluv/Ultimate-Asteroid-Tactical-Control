using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EntitySpawn : MonoBehaviour
{
    //Creates holders for game objects, the amount required to spawn, and how many have yet to spawn;
    public GameObject Targeter;
    public int targeter_amount;
    private int targeter_remain;

    public GameObject Floater;
    public int floater_amount;
    private int floater_remain;

    private GameObject spawnThis;

    public static int totalEntities;
    private int chosenEnt;
    private int spawnLocationNumber;


    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Transform spawnPoint5;
    public Transform spawnPoint6;
    public Transform spawnPoint7;
    public Transform spawnPoint8;
    public Transform spawnPoint9;
    public Transform spawnPoint10;

    //private Coroutine coroReference;

    public int waitTime;

    // Start is called before the first frame update
    void Start()
    {
        targeter_remain = targeter_amount;
        floater_remain = floater_amount;
        totalEntities = targeter_amount + floater_amount;
        DeathCount.PlayingFieldCount = 0;
        SpawnAvailable();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAvailable()
    {
        Debug.Log("Checking to see if space to spawn is available!");
        if (DeathCount.PlayingFieldCount >= 3)
        {
            StartCoroutine(nameof(noWaiter));
        }
        if (DeathCount.PlayingFieldCount < 3)
        {
            StartCoroutine(nameof(yesWaiter));
        }
    }

    IEnumerator noWaiter()
    {
        Debug.Log("Cannot spawn now, will check again in 3 seconds.");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Seconds complete.");
        SpawnAvailable();
    }

    IEnumerator yesWaiter()
    {
        Debug.Log("Space available. Spawning in 3 seconds.");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Seconds complete.");
        DeathCount.PlayingFieldCount += 1;
        SpawnEntity();
    }

    void ChooseLocation()
    {
        Debug.Log("A location is being chosen to spawn.");
        spawnLocationNumber = Random.Range(1, 10);
    }

    void ChooseEntity()
    {
        Debug.Log("Choosing an entity to be spawned.");
        var coinFlip = Random.Range(1, 3);
        Debug.Log(coinFlip);
        chosenEnt = coinFlip;
    }


    void SpawnEntity()
    {
        if (totalEntities != 0)
        {
            Debug.Log("Space is available, spawning an entitiy!");

            ChooseEntity();
            if (chosenEnt == 1)
            {
                if (targeter_remain != 0)
                {
                    Debug.Log("Chose targeter");
                    targeter_remain = targeter_remain - 1;
                    spawnThis = Targeter;
                }
                else
                {
                    spawnThis = Floater;
                }
                totalEntities -= 1;
            }
            else if (chosenEnt == 2)
            {
                if (floater_remain != 0)
                {
                    Debug.Log("Chose floater");
                    floater_remain = floater_remain - 1;
                    spawnThis = Floater;
                }
                else
                {
                    spawnThis = Targeter;
                }
                totalEntities -= 1;
            }

            ChooseLocation();
            switch (spawnLocationNumber)
            {
                case 1:
                    Instantiate(spawnThis, spawnPoint1.position, spawnPoint1.rotation);
                    Debug.Log("location 1");
                    break;
                case 2:
                    Instantiate(spawnThis, spawnPoint2.position, spawnPoint2.rotation);
                    Debug.Log("location 2");
                    break;
                case 3:
                    Instantiate(spawnThis, spawnPoint3.position, spawnPoint3.rotation);
                    Debug.Log("location 3");
                    break;
                case 4:
                    Instantiate(spawnThis, spawnPoint4.position, spawnPoint4.rotation);
                    Debug.Log("location 4");
                    break;
                case 5:
                    Instantiate(spawnThis, spawnPoint5.position, spawnPoint5.rotation);
                    Debug.Log("location 5");
                    break;
                case 6:
                    Instantiate(spawnThis, spawnPoint6.position, spawnPoint6.rotation);
                    Debug.Log("location 6");
                    break;
                case 7:
                    Instantiate(spawnThis, spawnPoint7.position, spawnPoint7.rotation);
                    Debug.Log("location 7");
                    break;
                case 8:
                    Instantiate(spawnThis, spawnPoint8.position, spawnPoint8.rotation);
                    Debug.Log("location 8");
                    break;
                case 9:
                    Instantiate(spawnThis, spawnPoint9.position, spawnPoint9.rotation);
                    Debug.Log("location 9");
                    break;
                case 10:
                    Instantiate(spawnThis, spawnPoint10.position, spawnPoint10.rotation);
                    Debug.Log("location 10");
                    break;
                default:
                    Console.WriteLine("Help, something broke with spawning.");
                    break;
            }

            SpawnAvailable();
        }
        else
        {
            Debug.Log("No more enemies to spawn.");
        }
        
    }
}
