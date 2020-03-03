using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int desiredNumOfEnemies;
    public int currentNumOfEnemies;
    public int timeBeforeChecking;

    public List<Transform> SpawnTransforms = new List<Transform>();
    public List<GameObject> TypesOfEnemies = new List<GameObject>();


    void Start()
    {
        foreach(Transform tf in gameObject.GetComponentsInChildren<Transform>())
        {
            if (tf != gameObject.transform)
            {
                SpawnTransforms.Add(tf);
            }
        }


        TotalEnemies();
    }

    private void TotalEnemies()
    {
        //How many enemies are alive
        Debug.Log(currentNumOfEnemies);
        if (currentNumOfEnemies == 3)
        {
            StartCoroutine(nameof(Wait));
        }
    }

    IEnumerator Wait()
    {
        Debug.Log("We are now waiting.");
        yield return new WaitForSeconds(timeBeforeChecking);
        Debug.Log("We are checking again.");
        TotalEnemies();
    }


}
