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

    private int totalEntities;
    private int chosenEnt;
    private int spawnLocationNumber;
    private int spawnedEntities;

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

    public Transform player_location;

    // Start is called before the first frame update
    void Start()
    {
        targeter_remain = targeter_amount;
        floater_remain = floater_amount;
        totalEntities = targeter_amount + floater_amount;
        spawnedEntities = 0;
        SpawnAvailable();
    }

    // Update is called once per frame
    void Update()
    {

        //Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
    }

    void SpawnAvailable()
    {
        Debug.Log("Checking to see if space to spawn is available!");
        if (spawnedEntities == 3)
        {
            Debug.Log("Cannot spawn now, will check again in 5 seconds.");
            //Make wait statement
            SpawnAvailable();
        }
        else
        {
            spawnedEntities = spawnedEntities + 1;
            SpawnEntity();
        }
    }

    void ChooseLocation()
    {
        Debug.Log("A location is being chosen to spawn.");
        spawnLocationNumber = Random.Range(1, 10);
    }

    void ChooseEntity()
    {
        Debug.Log("Choosing an entity to be spawned.");
        var coinFlip = Random.Range(1, 2);
        chosenEnt = coinFlip;
    }
   

    void SpawnEntity()
    {
        Debug.Log("Space is available, spawning an entitiy!");
        for (var i = 0; i < totalEntities; i++)
        {
            ChooseEntity();
            if (chosenEnt == 1)
            {
                targeter_remain = targeter_remain - 1;
                ChooseLocation();

                switch (spawnLocationNumber)
                {
                    case 1:
                        Instantiate(Targeter, spawnPoint1.position, spawnPoint1.rotation);
                        break;
                    case 2:
                        Instantiate(Targeter, spawnPoint2.position, spawnPoint2.rotation);
                        break;
                    case 3:
                        Instantiate(Targeter, spawnPoint3.position, spawnPoint3.rotation);
                        break;
                    case 4:
                        Instantiate(Targeter, spawnPoint4.position, spawnPoint4.rotation);
                        break;
                    case 5:
                        Instantiate(Targeter, spawnPoint5.position, spawnPoint5.rotation);
                        break;
                    case 6:
                        Instantiate(Targeter, spawnPoint6.position, spawnPoint6.rotation);
                        break;
                    case 7:
                        Instantiate(Targeter, spawnPoint7.position, spawnPoint7.rotation);
                        break;
                    case 8:
                        Instantiate(Targeter, spawnPoint8.position, spawnPoint8.rotation);
                        break;
                    case 9:
                        Instantiate(Targeter, spawnPoint9.position, spawnPoint9.rotation);
                        break;
                    case 10:
                        Instantiate(Targeter, spawnPoint10.position, spawnPoint10.rotation);
                        break;
                    default:
                        Console.WriteLine("Help, something broke with Targeters.");
                        break;
                }
                SpawnAvailable();
            }

            if (chosenEnt == 2)
            {
                floater_remain = floater_remain - 1;
                ChooseLocation();

                switch (spawnLocationNumber)
                {
                    case 1:
                        Instantiate(Floater, spawnPoint1.position, spawnPoint1.rotation);
                        break;
                    case 2:
                        Instantiate(Floater, spawnPoint2.position, spawnPoint2.rotation);
                        break;
                    case 3:
                        Instantiate(Floater, spawnPoint3.position, spawnPoint3.rotation);
                        break;
                    case 4:
                        Instantiate(Floater, spawnPoint4.position, spawnPoint4.rotation);
                        break;
                    case 5:
                        Instantiate(Floater, spawnPoint5.position, spawnPoint5.rotation);
                        break;
                    case 6:
                        Instantiate(Floater, spawnPoint6.position, spawnPoint6.rotation);
                        break;
                    case 7:
                        Instantiate(Floater, spawnPoint7.position, spawnPoint7.rotation);
                        break;
                    case 8:
                        Instantiate(Floater, spawnPoint8.position, spawnPoint8.rotation);
                        break;
                    case 9:
                        Instantiate(Floater, spawnPoint9.position, spawnPoint9.rotation);
                        break;
                    case 10:
                        Instantiate(Floater, spawnPoint10.position, spawnPoint10.rotation);
                        break;
                    default:
                        Debug.Log("Help, something broke with floaters.");
                        break;
                }
                SpawnAvailable();
            }
        }
    }
}
