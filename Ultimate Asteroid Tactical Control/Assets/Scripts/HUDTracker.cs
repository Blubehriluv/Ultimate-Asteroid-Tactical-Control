using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDTracker : MonoBehaviour
{

    public Text enemiesLeftNumber;
    public Text eliminationNumber;
    public static string holder;
    public static string holder1;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

        holder =  EntitySpawn.totalEntities.ToString();
        enemiesLeftNumber.text = holder;

        holder1 = DeathCount.TotalKilledByPlayer.ToString();
        eliminationNumber.text = holder1;
    }
}
    