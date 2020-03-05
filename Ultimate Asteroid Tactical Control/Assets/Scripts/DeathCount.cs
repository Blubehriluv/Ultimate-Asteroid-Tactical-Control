using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCount : MonoBehaviour
{
    public static int TotalKilled;
    public static int KilledByBox;
    public static int KilledByCol;
    public static int KilledByPlayer;
    public static int PlayingFieldCount;
    // Start is called before the first frame update
    void Start()
    {
        PlayingFieldCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
